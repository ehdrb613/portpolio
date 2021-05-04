<!doctype html>
<html>
<head>

	<title>회원 가입</title>
   <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0, user-scalable=no">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
   <link rel="stylesheet" type="text/css" href="css/input_style.css">
<script src="../js/jquery.js"></script>
<script src="../js/overlap_check.js" type="text/javascript" charset="utf-8"></script>
<script src="../js/select.js" type="text/javascript" charset="utf-8"></script>
<!--클릭 시 값 초기화  -->
<script src="http://code.jquery.com/jquery-1.8.3.js"></script>
<script src="http://code.jquery.com/ui/1.10.0/jquery-ui.js"></script>
<!--클릭 시 값 초기화 제이쿼리  -->
<script>
$(function() {
    $("#u_id").focus(function() { 
      $(this).val('');
    }).blur(function() { 
      if($(this).val() == "") { $(this).val(""); }
    });
 });
//text클릭 시 값초기화 
var idcheck=0;

function formCheck(){

         var id= "#u_name";
         var ptn=/^[가-힣]{2,6}$/;
         var msg="이름은 한글로 2글자에서 6글자로 입력하세요.";
         if(!check_item(id,ptn,msg)){
            return false;
         }
         
      do    
      {
            if(idcheck==1){break;}
            alert ("중복확인이 완료되지 않았습니다.");
            return false;
       }
        while(idcheck==0 && $("#u_id").val()!=""){ 
         
         id= "#u_tel";
         ptn=/^01[016789]-?[0-9]{3,4}-?[0-9]{4}$/;
         msg="'-'를 제외하고 입력하세요.";
         if(!check_item(id,ptn,msg)){
            return false;
         }
         id= "#u_email";
         ptn =/^[a-zA-Z0-9._]+[@]{1}([a-zA-Z0-9\-]+[.])+[a-zA-Z]{2,3}$/;
         msg="email을 잘못 입력하였습니다.";
         if(!check_item(id,ptn,msg)){
            return false;
         }
      }
} 
      function check_item(id,ptn,msg){
         var val = $(id).val();
         if(!ptn.test(val)){
            alert(msg);
            $(id).focus();
            return false;
         }
         return true;
       <?php
       session_start();
       $_SESSION["link_ok"] = "1"; 
       ?>
      }

function check_id2()
{
         
         var id = $("#u_id").val();
         $.get("check_id.php?id="+id, 
            function(data){
            if(data == "N")
            {
            idcheck = 0;
            }
  
         });

}
function check_id()
{
         var id = $("#u_id").val();
         $.get("check_id.php?id="+id, 
            function(data){
            if(data == "Y")
            {
            alert("사용가능한 아이디입니다.")
            idcheck = 1 ;
            $("u_pw1").focus();
            }
            else{
            alert("아이디를 사용할 수 없습니다.");
            idcheck = 0 ;
            $("#u_id").focus();
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
    <div id="title">회원가입</div>
   </header>

<form name = "member_form" action="input_ok.php" method="post" onsubmit="return formCheck();">
<div class="row">
   <label for="name">
   이  름
   </label>
   <input type="text" id="u_name" name="u_name" value="" placeholder="ex)학회장 박민수" autocomplete="off"/>
</div>

<div class="row">
   <label for="id">
   아이디
   </label>
   <input type = "text"  id = "u_id" name ="u_id" value ="" onkeydown="check_id2()"  placeholder="ex)grida123" autocomplete="off" / >
   <div>
   <input type = "button" id = "idcheck" value = "중 복 확 인" onclick="check_id()">
   </div>
</div>

<div class="row">
   <label for="pw1">
   비밀번호
   </label>
   <input type="password" id="u_pw1" name="u_pw1" value="" placeholder="최소 8자 이상 적어주세요"/>
</div>

<div class="row">
   <label for="pw2">
   비밀번호 확인
   </label>
   <input type="password" id="u_pw2" name="u_pw2" value="" />
</div>

<div class="row">
   <label for="birthday">
   생년월일
   </label>
   <input type="text" id="u_by" name="u_birthday" value="" placeholder="2017년1월1일 ex)170101" autocomplete="off" />
</div>

<div class="row">
   <label for="tel">
   휴대폰
   </label>
   <input type="text" id="u_tel" name="u_tel" value="" placeholder=" '-'없이 ex)01012345678" autocomplete="off" />
</div>

<div class="row">
   <label for="email">
   이메일
   </label>
   <input type="text" id="u_email" name="u_email" value="" placeholder="ex)grida@naver.com" autocomplete="off"/>

</div>

<div class="ctrl">
   <input type="submit" value="가입하기" >
</div>
</form>

</body>
</html>