<?
    
    include $_SERVER["DOCUMENT_ROOT"]."php/global.php"; 
    session_start();


    $id = $_SESSION["myAdmin"];
    $fn =$_SESSION["fn"];
    $c_name = $_SESSION["counselor"];

    $t_q1 = $_POST["t_q1"];
    $t_q2 = $_POST["t_q2"];
    $t_q3 = $_POST["t_q3"];
    $t_q4 = $_POST["t_q4"];
    $t_q5 = $_POST["t_q5"];
    $t_q6 = $_POST["t_q6"];
    $t_q7 = $_POST["t_q7"];
    $t_q8 = $_POST["t_q8"];
    $t_qt = $_SESSION["timecoms"];
    $u_dt = date("Y-m-d H:i:s");

    $connect = mysql_connect("localhost", "cozco2", "cell2242");
    mysql_select_db("cozco2",$connect);
    mysql_query("set names utf8");

    $sql = "INSERT INTO grida_t_t ";
    $sql.= "(id,t_q1,t_q2,t_q3,t_q4,t_q5,t_q6,t_q7,t_q8,t_qt,u_dt,fn,c_name,ok)";
    $sql.= " VALUES ";
    $sql.= "('$id', '$t_q1', '$t_q2', '$t_q3', '$t_q4', '$t_q5', '$t_q6', '$t_q7', '$t_q8', '$t_qt', '$u_dt', '$fn', '$c_name', '미등록')";
    $result = mysql_query($sql);





    if($result)
    {
      $sql="UPDATE grida_htp SET t = 'Y'";
      $result = mysql_query($sql);
      echo "<script>alert('다음 검사를 진행합니다.'); location.href='../htp_test/p_test1.html';</script>";
    }
    else
    {
      echo "<script>alert('질문을 다시 적어주세요.'); location.href='../htp_test/t_q.html';</script>";
    }
    mysql_close($connect);

    // 새 글 쓰기인 경우 리스트로..
    //echo ("<meta http-equiv='Refresh' content='1; URL=list.php'>");
    //1초후에 list.php로 이동함.
    
?>
