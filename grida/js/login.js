
function do_enter(e)
{
  if (e.keyCode==13)
  {
    var but=document.getElementById("login").click();
  }
  return 0;
}

function blank()
{
  var du = document.userinput;

  if(du.id.value =='')
  {
    alert("아이디를 입력하시오");
    du.id.focus();
    return false;
  }
  if(!du.pw.value)
  {
    alert("패스워드를 입력하시오");
    du.pw.focus();
    return false;
  }
}