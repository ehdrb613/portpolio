<?// h 이미지 저장

session_start();

$id = $_SESSION["myAdmin"];

header("Content-Type: text/html; charset= UTF-8 ");


$num = 1;

//현재 업로드 상태인지를 체크
if($_POST['mode'] == 'upload') {
	
//1. 업로드 파일 존재여부 확인
	if(!isset($_FILES['upload'])) {
		echo "<script>alert('업로드 파일 존재하지 않음' ); location.href='../htp_test/h_test.html';</script>";
		exit;
	}//if
		
//2. 업로드 오류여부 확인
 	if ($_FILES['upload']['error'] > 0) {
		switch ($_FILES['upload']['error']) {
			case 1:
			    echo "<script>alert('php.ini 파일의 upload_max_filesize 설정값을 초과함(업로드 최대용량 초과)'); location.href='../htp_test/h_test.html';</script>";
				exit;
			case 2:
				echo "<script>alert('50Mb를 초과했습니다.(업로드 최대용량 초과); location.href='../htp_test/h_test.html';</script>";
				exit;
			case 3:
				echo "<script>alert('파일 일부만 업로드 됨'); location.href='../htp_test/h_test.html';</script>";
				exit;
			case 4:
				echo "<script>alert('업로드된 파일이 없음'); location.href='../htp_test/h_test.html';</script>";
				exit;
			case 6:
				echo "<script>alert('사용가능한 임시폴더가 없음'); location.href='../htp_test/h_test.html';</script>";
				exit;
			case 7:
				echo "<script>alert('디스크에 저장할수 없음'); location.href='../htp_test/h_test.html';</script>";
				exit;
			case 8:
				echo "<script>alert('파일 업로드가 중지됨'); location.href='../htp_test/h_test.html';</script>";
				exit;
			default:
				echo "<script>alert('시스템 오류가 발생'); location.href='../htp_test/h_test.html';</script>";
				exit;
		} // switch
	}//if

//3. 업로드 제한용량 체크(서버측에서 50M로 제한)
	if($_FILES['upload']['size'] > 52428800) {
		echo "<script>alert('업로드 최대용량 초과'); location.href='../htp_test/h_test.html';</script>";
		exit;
	}//if

//4. 업로드 허용 확장자 체크(보편적인 jpg,jpeg,gif,png,bmp 확장자만 필터링)
	$ableExt = array('jpg','jpeg','gif','png','bmp');
	$path = pathinfo($_FILES['upload']['name']);
	$ext = strtolower($path['extension']);

	if(!in_array($ext, $ableExt)) {
		echo "<script>alert('허용되지 않는 확장자입니다.'); location.href='../htp_test/h_test.html';</script>";
		exit;
	}//if

//5. MIME를 통해 이미지파일만 허용(2차 확인)
	$ableImage = array('image/jpeg', 'image/JPG', 'image/X-PNG', 'image/PNG', 'image/png', 'image/x-png', 'image/gif','image/bmp','image/pjpeg');
	if(!in_array($_FILES['upload']['type'], $ableImage)) {
		echo "<script>alert('지정된 이미지만 허용됩니다.'); location.href='../htp_test/h_test.html';</script>";
		exit;
	}//if

//6. DB에 저장할 이미지 정보 가져오기(width,height 값 활용)
	$img_size = getimagesize($_FILES['upload']['tmp_name']);

	//DB연결
	$db = @new mysqli('localhost','cozco2','cell2242','cozco2');
	if(mysqli_connect_errno()) {
		echo "<script>alert('DB연결오류.'); location.href='../htp_test/h_test.html';</script>";
		exit;
	}//if

	//do~while: 새로만든 파일명이 중복일경우 반복하기 위한 루틴
	do{

//6. 새로운 파일명 생성(마이크로타임과 확장자 이용)
		$time = explode(' ',microtime());
		$fileName = $id."_h_t_".$num++.'.'.strtoupper($ext);

		//중요 이미지의 경우 웹루트(www) 밖에 위치할 것을 권장(예제 편의상 아래와 같이 설정)
		$filePath = $_SERVER['DOCUMENT_ROOT'].'/grida/t_img/h_t_img/';

//7. 생성한 파일명이 DB내에 존재하는지 체크
		$query = sprintf("SELECT * FROM grida_imege WHERE db_filename = '%s'",$fileName);
		$result = $db->query($query);

	//생성한 파일명이 중복하는 경우 새로 생성해서 체크를 반복(동시저장수가 대량이 아닌경우 중복가능 희박)
	}while($result->num_rows > 0); 

	//db에 저장할 정보 가져옴 
	$upload_filename = $db->real_escape_string($_FILES['upload']['name']);
	$file_size = $_FILES['upload']['size'];
	$file_type = $_FILES['upload']['type'];
	$upload_date = date("Y-m-d H:i:s");
	$id = $_SESSION["myAdmin"];

	//오토커밋 해제
	$db->autocommit(false);

//8. db에 업로드 파일 및 새로 생성된 파일정보등을 저장
	$query = sprintf("INSERT INTO grida_imege
		(upload_filename,db_filename,file_path,file_size,file_type,upload_date,id,width,height) 
		VALUES ('%s','%s','%s',%d,'%s','%s','%s',%d,%d)",
		$upload_filename, $fileName, $filePath, $file_size, $file_type, $upload_date, $id,$img_size[0],$img_size[1]);

	$db->query($query);

	//DB에 파일내용 저장 성공시
	if($db->affected_rows > 0) {

//9. 업로드 파일을 새로 만든 파일명으로 변경 및 이동
		if (move_uploaded_file($_FILES['upload']['tmp_name'], $filePath.$fileName)) {

//10. 성공시 db저장 내용을 적용(커밋)
			$db->commit();
			 echo "<script>alert('이미지 업로드 완료. 다음페이지로 넘어갑니다.'); location.href='../htp_test/h_q.html';</script>";
			 $_SESSION["fn"] = "$fileName";
		}else{
			//실패시 db에 저장했던 내용 취소를 위한 롤백
			$db->rollback();
			 echo "<script>alert('업로드 실패.'); location.href='../htp_test/h_q.html';</script>";
			exit;
		}//if
	}//if
}//if
?>


