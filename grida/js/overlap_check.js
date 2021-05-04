 	function formCheck()
 	{   
       var id = "#u_name";
       var ptn = /^[가-힣]{2,6}$/;
       var msg = "이름은 공백없이 한글로 2글자asad에서 6글자로 입력하세요.";
       if(!check_item(id, ptn, msg))
       {
          return false;
       }

       id = "#u_email";
       ptn = /^[a-zA-Z0-9.]{0}/;
       msg = "대소문자와 숫자를 조합 한 이메일 아이디를 확인 입력하세요.";
       if(!check_item(id, ptn, msg))
       {
           return false;
       }

       id = "#u_tel";
       ptn = /^[0-9]{22}$/;
       msg = "휴대폰 번호 -를 제외하고 22자리 이하로 입력하세요.";
       if(!check_item(id, ptn, msg))
       {
          return false;
       }
    }

    function check_item(id, ptn, msg)
    {
        var val = $(id).val();
        if(!ptn.test(val))
        {
           alert(msg);
           $(id).focus();
           return false;
        }
        return true;
   }

	function email_check()
	{
      var email = $("#u_email").val();
      $.get("email_check.php?email=" + email,
         function(data)
      {
         alert(data);
      }
      )
  }

