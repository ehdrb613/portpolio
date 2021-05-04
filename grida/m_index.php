<?php //include $_SERVER["DOCUMENT_ROOT"]."php/global.php"; //세션시간...몇주죠?
  session_start();
 ?>


<!DOCTYPE html>
<html>
<head>
	<title>그리다</title>

    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0, user-scalable=no">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<!--index 스타일 -->
	
    <link href="css/index_style.css" rel="stylesheet" type="text/css"/>
    <!-- Link Swiper's CSS -->
    <link rel="stylesheet" href="css/swiper.min.css">
</head>
<body>
<script>
	function msg1()//로그인후 이용가능합니다 메시지
	{
		alert("로그인후 이용가능합니다.");
	}
</script>


<div id="base">
	<!--해더 시작-->
	<header>
		<ul id="user_menu" >
			<li><a href="#"><img src="img/usermenu.png"/></a></li>
	<?php
		if(isset($_SESSION["myAdmin"])){
	?>
		<!--로그아웃 되었을때 로그인 누르면 로그인 페이지-->
		<li><a href=php/logout.php><input class="login_btn" type="button" value="로그아웃" onclick=""></a></li>
	<?php
	}else{
	?>
		<!--로그인 되었을때 로그아웃 버튼 누르면 세션값 없애 줘야 됨-->
		<li><a href=sub/login.html><input class="login_btn" type="button" value="로그인"></a></li>
	<?php
	}
	?>		
		</ul>
		<div id="main_rogo">
		<img src="img/logo.png" />
		</div>
	</header>
	
	<section>  
	<?php 
		if(isset($_SESSION["myAdmin"])){//로그인 상태 시작 
	     ?>
		<!--무료h진단-->
		<div id="free_test_h" class="main_menu">
			<a href="htp_test/htp.php"><p class="menu_name">그림 진단 GO</p></a>
		</div>
		<!--그림진단-->
		<div id="draw_test" class="main_menu">
			<a href="sub/curekind.html"><p class="menu_name">진단 종류</p></a>
		</div>
		<!--보관함-->
		<div id="cont_index" class="main_menu">
			<?php
			if($_SESSION["myAdmin"]=="counselor1"){

				?>
			<a href="consultant/consultant.php"><p class="menu_name">의사 전용</p></a>

			<?php
			}
			else{
				?>
			<a href="consultant/consultant.php"><p class="menu_name">상담 보관함</p></a>
			<?php
			}
			?>
		</div>
		<!--공지사항-->
		<div id="notice_main" class="main_menu">
			<a href="#"><p class="menu_name">공지 사항</p></a>
		</div>
		<!--고객센터-->
		<div id="customer_center" class="main_menu">
			<a href="#"><p class="menu_name">고객 센터</p></a>
		</div>
	    <?php
	     } //로그인 상태 끝 
	    else if(!isset($_SESSION["myAdmin"])){ //로그인이 안됨 시작
		?><!--무료h진단-->
		<div id="free_test_h" class="main_menu" onclick="msg1()">
			<a href="sub/login.html"><p class="menu_name">그림 진단 GO</p></a>
		</div>
		<div id="draw_test" class="main_menu">
			<a href="sub/curekind.html"><p class="menu_name">진단 종류</p></a>
		</div>
		<div id="cont_index" class="main_menu" onclick="msg1()">
			<a href="sub/login.html"><p class="menu_name">상담 보관함</p></a>
		</div>
		<div id="notice_main" class="main_menu">
			<a href="#"><p class="menu_name">공지 사항</p></a>
		</div>
		<div id="customer_center" class="main_menu">
			<a href="#"><p class="menu_name">고객 센터</p></a>
		</div>
	    <?php
		}//로그인 안됨 끝 
	    ?>
	<div id=swiper_space>
	<!-- Swiper -->
    <div class="swiper-container swiper-container-h">
        <div class="swiper-wrapper">
           <div class="swiper-slide"> <img src="img/intro1.jpg"/> </div>
           <div class="swiper-slide"> <img src="img/intro2.jpg"/> </div>
           <div class="swiper-slide"> <img src="img/intro3.jpg"/> </div>
        </div>
        <!-- Add Pagination -->
        <div class="swiper-pagination swiper-pagination-h"></div>
    </div>

    	<!-- Swiper JS -->
	    <script src="js/swiper.min.js"></script>

	    <!-- Initialize Swiper -->
	    <script>
	    var swiperH = new Swiper('.swiper-container-h', {
	        pagination: '.swiper-pagination-h',
	        paginationClickable: true,
	        spaceBetween: 50
	    });
	    var swiperV = new Swiper('.swiper-container-v', {
	        pagination: '.swiper-pagination-v',
	        paginationClickable: true,
	        direction: 'vertical',
	        spaceBetween: 50
	    });
	    </script>
    </div>
    </section>

	<!--푸터시작-->
	<footer>
		<div id="call_number">
			<p id="call">CALL CENTER</p> 
			<p id="number">1588-9292</p>
		</div>
		<div id="time">	
			<span id="time2">
				<span id="time1">평일</span>
				: 오전 09:00 ~ 오후 06 : 00
			<br/>
				<span id="time3">점심</span>
				: 오후 12:00 ~ 오후 02 : 00
			</span>
			<div class="custom1">
			<pre>전화문의가 많을 시 연결이 어려울 수 있습니다.
<span>고객 센터</span> 바로가기를 이용하시면 보다 신속하고
정확한 답변을 받으실 수 있습니다.</pre>
			</div>
		</div>
	</footer>	
</div>
</body>
</html>