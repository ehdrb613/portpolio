<?

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
 //# DB연결 설정 #//
 $connect = mysql_connect("localhost", "cozco2", "cell2242");
    mysql_select_db("cozco2",$connect);
    mysql_query("set names utf8");

 //# 패스워드 찾기 #//
 if($mode == "pw_find")
 {
  $qry_result = mysql_query(" select * from grida_member where id = '$id' ",$connect);
  //이메일 인증 된것을 초기화 
  $row = mysql_fetch_array($qry_result);
  $sql="UPDATE grida_member SET flag = 'false' WHERE id = '$id'";
  $result = mysql_query($sql);
  $sql="UPDATE grida_member SET e_confirm = '$random' WHERE id = '$id'";
  $result = mysql_query($sql);
  
  if(empty($row)) //입력된 아이디 값이 없을때
  {
  echo "<script>alert('아이디를 찾을수 없음');window.close();</script>";
  }
  else //입력된 아이디가 있어서 이메일에 인증번호 전송  
  {
      
         $smtp_mail_id = "momoiro4404@gmail.com"; //예)test@naver.com 혹은 test@gmail.com 등의 형식
         $smtp_mail_pw = "momoiro0788"; 
         $title = "그리다 인증번호 입니다."; //예)홍길동님의 문의사항 등록되었습니다. 
         $from_name = "그리다";
         $from_email = "momoiro4404@gmail.com";

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
           $mail->AddAddress($row[email], $row[name]);  // 받을 사람 email 주소와 표시될 이름 (표시될 이름은 생략가능)
           $mail->Subject = $title;         // 메일 제목
           $mail->MsgHTML($content);         // 메일 내용 (HTML 형식도 되고 그냥 일반 텍스트도 사용 가능함)
           $mail->Send();              // 실제로 메일을 보냄

          
         } catch (phpmailerException $e) {
           echo $e->errorMessage();
         } catch (Exception $e) {
            echo $e->getMessage();
         }
      echo "<script>alert('$row[id]에 등록된 이메일 $row[email]로 인증번호를 전송하였습니다.');window.close();</script>";
       //# 이메일전송 #//

  }
}
?>
<!DOCTYPE html>
<html>
<head>
	<meta charset="UTF-8">
	<script type="text/javascript">

 function pw_send()
 {
  form = document.pw_form;
  if (form.id.value == "")
  {
   alert("패스워드를 찾을 아이디를 입력해주십시오.");
   form.id.focus();
   return false;
  }
 }


   </script>
</head>
<body>

<form name="pw_form" method="post" action="password1.php?mode=pw_find" onSubmit="return pw_send();">
<h2>비밀번호를 찾으실 아이디를 입력하세요</h2>
<div class="row">
   <label for="id">
      <td>아이디</td>
  <input type="text" name="id" id="id">
  <input type="submit" value="비밀번호 찾기"  \>
</div>
 </form>
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
            var confirm = $("#u_confirm").val();
            $.get("pw_reset.php?confirm="+confirm,
            function(data){
            });
            document.location.href='pw_reset.php?confirm='+confirm;

        }
        else
        {
            alert("인증되지 않았습니다.");
            div.confirm.focus();
        }
    });
}
</script>
<!--이메일인증 폼 -->
 <div class="row">
   <label for="confirm">
   <span class="required"></span>
   이메일 인증
   </label>
   <input type="text" id="u_confirm" name="u_confirm" value="" />
   <input type="button" value="이메일인증" onclick="check_confirm()" />
</div>
</body>
</html>



