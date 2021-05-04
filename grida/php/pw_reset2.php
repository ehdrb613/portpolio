<?php 

            if(isset($_GET["pw"]) && isset($_GET["confirm"]))
            {
                  $pw1 = $_GET["pw"];
                  $u_confirm = $_GET["confirm"];
                  $connect = mysql_connect("localhost", "cozco2", "cell2242");
                  mysql_select_db("cozco2",$connect);
                  mysql_query("set names utf8");

                  $sql="UPDATE grida_member SET pw = '$pw1' WHERE  e_confirm = '$u_confirm'";
                  $result = mysql_query($sql);
                  echo "비밀번호가 변경되었습니다.";
            }
              mysql_close($connect);
?>
