<!doctype html>
<head>

<script language="javascript">
function FormSubmit()
{
 var frm = document.confirm_form;
 pop_win = window.open("","pop_win","scrollbars=no,width=300,height=200,left=250,top=250");
 frm.target = "pop_win";
 frm.action = "confirm.php";
 frm.submit();
 frm.focus();
}
</script>


</head>
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

    if($result)
    {
      echo $name."님 등록 되었습니다.";
    }
    else
    {
      echo $name."님 등록이 되지않습니다.";
    }
    mysql_close($connect);


$smtp_mail_id = "momoiro4404@gmail.com"; //예)test@naver.com 혹은 test@gmail.com 등의 형식
$smtp_mail_pw = "momoiro0788"; 
$to_email = $_POST["u_email"]; //예) test@naver.com
$to_name = $_POST["u_name"]; //예)홍길동
$title = "그리다 인증번호 입니다."; //예)홍길동님의 문의사항 등록되었습니다. 
$from_name = "그리다";
$from_email = "momoiro4404@gmail.com";

    $connect = mysql_connect("localhost", "cozoco2", "cell2242");
    mysql_select_db("cozco2",$connect);
    mysql_query("set names utf8");
    $sql = "INSERT INTO grida_member ";
    $sql.= "(e_confirm)";
    $sql.= " VALUES ";
    $sql.= "('$random')";
    $result = mysql_query($sql);

    mysql_close($connect);
$content = "인증번호: ".$random;

session_start();
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

echo "메일을 전송하였습니다.적으신 이메일로 전송된 인증코드를 입력하시면 로그인이 가능합니다.";



?>
<form name = "confirm_form" method="post"">
<div class="row">
   <label for="confirm">
   <span class="required"></span>
   이메일 인증
   </label>
   <input type="text" id="u_confirm" name="u_confirm" value="" />
   <input type="submit" value="이메일인증" onclick="FormSubmit()">
</div>

</html>

