<?
    
    include $_SERVER["DOCUMENT_ROOT"]."php/global.php"; 
    session_start();


    $id = $_SESSION["myAdmin"];
    $fn =$_SESSION["fn"];
    $c_name = $_SESSION["counselor"];

    $p_q1 = $_POST["p_q1"];
    $p_q2 = $_POST["p_q2"];
    $p_q3 = $_POST["p_q3"];
    $p_q4 = $_POST["p_q4"];
    $p_q5 = $_POST["p_q5"];
    $p_q6 = $_POST["p_q6"];
    $p_q7 = $_POST["p_q7"];
    $p_qt = $_SESSION["timecoms"];
    $u_dt = date("Y-m-d H:i:s");

    $connect = mysql_connect("localhost", "cozco2", "cell2242");
    mysql_select_db("cozco2",$connect);
    mysql_query("set names utf8");

    $sql = "INSERT INTO grida_p_t2 ";
    $sql.= "(id,p_q1,p_q2,p_q3,p_q4,p_q5,p_q6,p_q7,p_qt,u_dt,fn,c_name,ok)";
    $sql.= " VALUES ";
    $sql.= "('$id', '$p_q1', '$p_q2', '$p_q3', '$p_q4', '$p_q5', '$p_q6', '$p_q7' , '$p_qt', '$u_dt', '$fn', '$c_name', '미등록')";
    $result = mysql_query($sql);





    if($result)
    {
      $sql="UPDATE grida_htp SET p2 = 'Y'";
      $result = mysql_query($sql);
      echo "<script>alert('모든 검사가 끝났습니다. 보관함으로 이동합니다.'); location.href='../sub/storage.php';</script>";
    }
    else
    {
      echo "<script>alert('질문을 다시 적어주세요.'); location.href='../htp_test/p_q2.html';</script>";
    }
    mysql_close($connect);

    // 새 글 쓰기인 경우 리스트로..
    //echo ("<meta http-equiv='Refresh' content='1; URL=list.php'>");
    //1초후에 list.php로 이동함.
    
?>
