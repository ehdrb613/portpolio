<?php
if(isset($_GET["id"]))
{
      $id=$_GET["id"];

      $connect = mysql_connect("localhost", "cozco2", "cell2242");
      mysql_select_db("cozco2",$connect);
      mysql_query("set names utf8");
      //localhost 의 exam 계정 exam 비번 exam DB 연결
          //utf8로 설정
      $sql="SELECT id FROM grida_member WHERE id='$id'";
      $result=mysql_query($sql);
      $rows=mysql_num_rows($result);
      // 결과 레코드 세트에 존재하는 행의 수를 반환
      if($rows == 1 || $id =="")
      {
         echo "N";

      }
      else
      {
         echo "Y";
       session_start();
      $_SESSION["myAdmin"] = $id;
      }
      //strpos : 
   }
   mysql_close($connect);


?>
