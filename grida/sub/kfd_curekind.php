<?php //include $_SERVER["DOCUMENT_ROOT"]."php/global.php"; //세션시간...몇주죠?
  session_start();
 ?>
<!DOCTYPE html>
<html>
<head>
  <title>그리다</title>
  <meta charset="utf-8">
       <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0, user-scalable=no">
       <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <!--index 스타일 -->
    <link href="../css/kfd_curekind_style.css" rel="stylesheet" type="text/css"/>

  <!-- <script src=""></script> -->
</head>
<?php 
    if(isset($_SESSION["myAdmin"])){//로그인 상태 시작 
?>
<body>
	<header>
  <div id="return">
  <a href="curekind.html">    
    <img src="../img/화살표2.png"/>
  </a>
</div>
		<div id="rogo"><img src="../img/logowhite.png"></div>
    <div id="title">동적 가족화 검사</div>
	</header>

  <section>
  	<div id="img"><img src="../img/HTP검사.jpg"></div>
    <div id="text">동적 가족화 검사는 ~~~~~~~~~~~~~~~~~~~~~~~~~</div>
  </section>
</body>
<?php
} //로그인 상태 끝 
 else if(!isset($_SESSION["myAdmin"])){ //로그인이 안됨 시작
  echo "<script>alert('로그인후 이용가능합니다.'); document.location.href='../sub/login.html';</script>";
 }
?>
</html>