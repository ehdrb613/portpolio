<?php 
session_start();
if(isset($_GET["confirm"])){
$u_confirm = $_GET["confirm"]; 
//echo $u_confirm;
if(!isset($_SESSION["myAdmin"])){
    echo "<script>alert('정상적인 접속이아닙니다.'); document.location.href='password.php';</script>";//로그인 상태 시작 
  }
}
?>
<!doctype html>
<html>
<head>
    <title>그리다</title>
   <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0, user-scalable=no">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
      <script src="../js/jquery.js"></script>
      <link href="css/pw_reset_style.css" rel="stylesheet" type="text/css"/>
  <script type="text/javascript">
  
        function check_pw()//비밀번호 정규식과 전송 if 함수 
      {
               
               var pw = $("#u_pw1").val();
               var confirm = <?php echo $_GET["confirm"] ;?>;
               $.get("pw_reset2.php?pw="+pw,"&confirm="+confirm,
                  function(data){
                  alert(data);
               });
              document.location.href='../sub/login.html';
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
    <div id="title">비밀번호 찾기</div>
  </header>

<section>
<h2>비밀번호를 재설정해주세요</h2>
<form>

<div class="row">
<label for="pw1">
<span class="required"></span>
비밀번호
</label>

<input type="password" id="u_pw1" name="u_pw1" value="" placeholder="최소 8자 이상 적어주세요"/>
</div>

<div class="row">
<label for="pw2">
<span class="required"></span>
비밀번호 확인
</label>

<input type="password" id="u_pw2" name="u_pw2" value=""  placeholder="같은 비밀번호를 적어주세요"/>
<input type="button" value="재설정" onclick="check_pw()" /> 
</div>

</form>
</section>

</body>
</html>
