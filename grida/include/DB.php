<?php 

//상위 폴더에 dbcon.php 라는 이름으로 include폴더에 저장시켜 놓았다.

 $dbcon = mysql_connect("localhost","grida","grida123");
 mysql_select_db("grida",$dbcon);

?>
