<?php
  session_start();
 function session($name)
 {
  if(isset($_SESSION["$name"]))
  {
   return $_SESSION["$name"];
  }
  return "";
 }
 $_SESSION["userid"] = "";
 $userid = session("userid");
?>

