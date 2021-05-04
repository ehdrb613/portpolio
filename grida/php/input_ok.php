<?php 
    session_start();
    if(!isset($_SESSION["link_ok"])){
    echo isset($_SESSION["link_ok"]); 
    echo "<script>alert('정상적인 접속이아닙니다.')</script>";
    //echo "<script>document.location.href='input.php';</script>";
  }
?>
<!doctype html>
<head>
    <title>그리다</title>
   <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0, user-scalable=no">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<link rel="stylesheet" type="text/css" href="css/input_ok_style.css">
<script src="../js/jquery.js"></script>
<script language="javascript">

function check_confirm()
{
    var confirm = $("#u_confirm").val();
    $.get("confirm.php?confirm="+confirm, 
    function(data){
        if(data == "Y")
        {
            alert("인증되었습니다.");
            <?php SESSION_DESTROY(); ?>

            document.location.href='../sub/login.html';
        }
        else
        {
            alert("인증되지 않았습니다.");
        }


    });
}
</script>


</head>
<body>
  <header>
    <div id="return">
    <a href="../sub/login.html">
      <img src="../img/화살표2.png"/>
    </a>
    </div>
        <div id="rogo"><img src="../img/logowhite.png"></div>
      <div id="title">회원가입인증</div>
     </header>
<?php

function genRandom($length = 5) 
{
    $char = '0123456789';
    $result = '';
    for($i = 0; $i <= $length; $i++) 
    {
        $result .= $char[mt_rand(0, strlen($char))];
    }

    return($result);
}
    
$random = genRandom(6);

    $name = $_POST["u_name"];
    $id = $_POST["u_id"];
    $pw1 = $_POST["u_pw1"];
    $tel = $_POST["u_tel"];
    $birthday = $_POST["u_birthday"];
    $email=$_POST["u_email"];
    


    $connect = mysql_connect("localhost", "cozco2", "cell2242");
    mysql_select_db("cozco2",$connect);
    mysql_query("set names utf8");

    $sql = "INSERT INTO grida_member ";
    $sql.= "(name,id,pw,birthday,tel,email,e_confirm, flag)";
    $sql.= " VALUES ";
    $sql.= "('$name', '$id', '$pw1', '$birthday', '$tel', '$email', '$random' ,'false')";
    $result = mysql_query($sql);

?>

<div class="mail_confirm">
<?php
    if($result)
    {
      echo $name."님 등록 되었습니다.";
    }
    else
    {
      echo $name."님 등록이 되지않습니다.";
    }

    session_start();
    $_SESSION["cl_name"] = "$name";
    
?>
</div>
<?php

$smtp_mail_id = "momoiro4404@gmail.com"; //예)test@naver.com 혹은 test@gmail.com 등의 형식
$smtp_mail_pw = "momoiro)&88"; 
$to_email = $_POST["u_email"]; //예) test@naver.com
$to_name = $_POST["u_name"]; //예)홍길동
$title = "그리다 인증번호 입니다."; //예)홍길동님의 문의사항 등록되었습니다. 
$from_name = "그리다";
$from_email = "momoiro4404@gmail.com";


 

$content = "<div style='width:auto; margin:0 auto; background-color:#7db0e0; font-family:고딕;'>
<table align='center' border='0'>
<tr align='center'>
<td align='center'><img src='../img/logowhite.png' width='150px'/></td>
<td style='font-size:30px; font-weight:900; color:white;'>그리다<br>가입인증</td>
</tr>
<tr>
<td colspan='2' align='center' style='font-size:25px; font-weight:400;'>미술치료서비스 그리다입니다</td>
</tr>
<tr>
<td colspan='2' align='center' style='font-size:25px; font-weight:900;'>인증번호: {$random}</td>
</tr>
<tr>
<td colspan='2' align='center' height='100px'><a href='http://withcell.net/grida' style='color:white; font-size:20px;'>그리다 바로가기</a></td>
</tr>
</tabel>
</div>";

$_SESSION["R_session"] = $random;

//$smtp_use = 'smtp.naver.com'; //네이버 메일 사용시
$smtp_use = 'smtp.gmail.com'; //구글 메일 사용시 주석제거
if ($smtp_use == 'smtp.naver.com') { 
$from_email = $smtp_mail_id; //네이버메일은 보내는 id로만 전송이가능함
}else {
 $from_email = $from_email; 
}
 
//메일러 로딩
require_once("../include/PHPMailer/class.phpmailer.php");
require_once("../include/PHPMailer/class.smtp.php");
$mail = new PHPMailer(true);
$mail->IsSMTP();
try {
  $mail->Host = $smtp_use;   // email 보낼때 사용할 서버를 지정
  $mail->SMTPAuth = true;          // SMTP 인증을 사용함
  $mail->Port = 465;            // email 보낼때 사용할 포트를 지정
  $mail->SMTPSecure = "ssl";        // SSL을 사용함
  $mail->Username   = $smtp_mail_id; // 계정
  $mail->Password   = $smtp_mail_pw; // 패스워드
  $mail->SetFrom($from_email, $from_name); // 보내는 사람 email 주소와 표시될 이름 (표시될 이름은 생략가능)
  $mail->AddAddress($to_email, $to_name);  // 받을 사람 email 주소와 표시될 이름 (표시될 이름은 생략가능)
  $mail->Subject = $title;         // 메일 제목
  $mail->MsgHTML($content);         // 메일 내용 (HTML 형식도 되고 그냥 일반 텍스트도 사용 가능함)
  $mail->Send();              // 실제로 메일을 보냄

 
} catch (phpmailerException $e) {
  echo $e->errorMessage();
} catch (Exception $e) {
   echo $e->getMessage();
}

 ?><div class="mail_text"><?php echo"메일을 전송하였습니다.적으신 이메일로 전송된 인증코드를 입력하시면 로그인이 가능합니다.";?></div>
<script type="text/javascript">
    
    function return_mail()
  {
        location.reload();
        <?php
          $sql="UPDATE grida_member SET e_confirm = '$random' WHERE id = '$id'";
           $result = mysql_query($sql);
          mysql_close($connect);
        ?>
        //location.href=document.location;
        alert("이메일로 인증코드를 재전송 하였습니다.");
  }

</script>
  

<form>
<div class="row">
   <label for="confirm">
   이메일 인증
   </label>
   <input type="text" id="u_confirm" name="u_confirm" value="" />
   </div> 
   <input type="button" value="인증코드 재전송" onclick="return_mail()">
   <input type="button" value="이메일인증" onclick="check_confirm()">
</form>
</body>
</html>

