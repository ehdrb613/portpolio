<!doctype html>
<html>
<head>

	<title>회원 가입</title>
	<meta charset="utf-8">

<script src="../js/jquery.js"></script>
<script src="../js/overlap_check.js" type="text/javascript" charset="utf-8"></script>
<script src="../js/select.js" type="text/javascript" charset="utf-8"></script>

<script>
$(document).ready(function()
{                   // jquery load
    $("#idcheck").click(function()
    {                // idcheck라는 id를 가진 버튼이 클릭이 되면
       var id_val = $("#u_id").val();         // insert_id라는 id를 가진 input의 값을 id_val이란 변수에 입력
       $.ajax({
         url: 'check_id.php?id='+id_val, type: 'GET', success: function(data)
         {

            if(data == 'Y') 
            {      //리턴이 Y이면,
               window.open('이 아이디는 생성할 수 있습니다.');
               exit;
            }
            else(data =='N')
            {    // 리턴이 N이면,
               alert('아이디가 중복됩니다.');
               exit; 
            }
         }
      });
    });
 });
</script>

</head>
<body>
<h1>회원가입</h1>
<form name = "member_form" action="input_ok.php" method="post" onsubmit="//return formCheck();">
<div class="row">
   <label for="name">
   <span class="required"></span>
   이름
   </label>
   <input type="text" id="u_name" name="u_name" value="" />
</div>

<div class="row">
   <label for="id">
   <span class="required"></span>
   아이디
   </label>
   <input type = "text" id = "u_id" name ="u_id" value = "" />
   <input type = "button" id = "idcheck" value = "중복확인">
</div>

<div class="row">
   <label for="pw1">
   <span class="required"></span>
   비밀번호
   </label>
   <input type="password" id="u_pw1" name="u_pw1" value="" />
</div>

<div class="row">
   <label for="pw2">
   <span class="required"></span>
   비밀번호 확인
   </label>
   <input type="password" id="u_pw2" name="u_pw2" value="" />
</div>

<div class="row">
   <label for="birthday">
   <span class="required"></span>
   생년월일
   </label>
   <input type="text" id="u_by" name="u_birthday" value=""  />
</div>

<div class="row">
   <label for="tel">
   <span class="required"></span>
   휴대폰
   </label>
   <input type="text" id="u_tel" name="u_tel" value="" />
</div>

<div class="row">
   <label for="email">
   <span class="required"></span>
   이메일
   </label>
   <input type="text" id="u_email" name="u_email" value=""  />

   <input type="button" value="이메일인증" onclick="window.open('mailSample.php')">
</div>

<div class="row">
   <label for="e_confirm">
   <span class="required"></span>
   이메일 인증
   </label>
   <input type="text" id="u_tel" name="u_tel" value="" />
</div>

<div class="ctrl">
   <input type="submit" value="등록">
</body>
</html>