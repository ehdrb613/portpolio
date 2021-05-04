<?php //include $_SERVER["DOCUMENT_ROOT"]."php/global.php"; //세션시간...몇주죠?
  session_start();
 ?>
<!DOCTYPE html>
<html>
<head>
 		<meta charset="utf-8">
       <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0, user-scalable=no">
       <meta http-equiv="Content-Type" content="text/html; charset=euc-kr">
       <link rel="stylesheet" type="text/css" href="../css/htp/htp_style.css">
       <script src="../js/htp.js" type="text/javascript" charset="utf-8"></script>
	<title>
		htp
	</title>

</head>
<?php 
    if(isset($_SESSION["myAdmin"])){//로그인 상태 시작 
?>
<body>
<header>
  <div id="return">
  <a href="../sub/choice.html">
    <img src="../img/화살표2.png"/>
  </a>
  </div>
    <div id="rogo"><img src="../img/logowhite.png"></div>
    <div id="title">HTP 검사</div>
  </header>


    
        <div class = "in">
        <pre><br><h3>집(House),나무(Tree),사람(Person)
        </h3></pre>
 
        <div id="divBtn1">
            <input class = "tip" type="button" name="btnTest1_1" value="검사 진행 방법" onclick="javascript:fn('divHid1')"/>
          </div>
          <div id="divHid1" style="display:none;">
            
            <p><h4>
            1.HTP검사란 H(집)T(나무)P(사람)을 그림으로 심리를 검사하는 그림 검사의 한 종류입니다.<br><br>
            2. 도화지 및 스케치북을 준비하세요. <br><br>
            3. 각 검사마다 도화지 및 스케치북의 방향이 다르니 참고하여 두시길 바랍니다. <br><br> 
            4. 하나의 그림당 시간제한은 없으나 그림을 그리는데 망설여 시간이 길어질경우 편한한 분위기를 만들어 쉽게 접근 할수있게 해주세요.<br><br>
            5.그림을 다그리시면 촬영후 사진선택을 하셔서 사진을 저장해주세요.<br><br>
            6. 그후 준비된 설문에 답변해주시면 되겠습니다. 평균 검사시간은 40~50분 가량입니다. 
            <br><br> 
            7. 검사과 완료되시면 평균 1~3일의 시간이 필요합니다. 결과는 차후 문자 공지해 드리겠습니다. 
          </h4></p>

        </div>
    
        <div id="divBtn3">
        <a href="h_test.html">
        <button class = "st" type='button' value='시작하기'>시작하기</button>
        </a>
        </div>
</body>
<?php
} //로그인 상태 끝 
 else if(!isset($_SESSION["myAdmin"])){ //로그인이 안됨 시작
  echo "<script>alert('로그인후 이용가능합니다.'); document.location.href='../sub/login.html';</script>";
 }
?>
</html>
