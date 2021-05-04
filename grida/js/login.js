
       function do_logon()
       {
        var id = document.getElementById("id"); // 오브젝트선언?
        var pw = document.getElementById("pw");
        var but = document.getElementById("but");
        var id_td=document.getElementById("id_td");
        var pw_td=document.getElementById("pw_td");
        if (id.value == "웨비2")
        { 
         if(pw.value == "123")
         {
          location.replace("sub/main_in.html"); 
         }
         else
         {
          alert("비밀번호 오류입니다");
          //pw.focus(); 커서이동.
          pw.select();
         }
        }
        else
        {
         alert("아이디 오류입니다");
        }
       }
       function do_enter(e)
       {
        if (e.keyCode==13)
        {
         var but=document.getElementById("but").click();
        }
        return 0;
       }