<?
    
    include $_SERVER["DOCUMENT_ROOT"]."php/global.php"; 
    session_start();


    $id = $_SESSION["myAdmin"];

    $h_q1 = $_POST["h_q1"];
    $h_q2 = $_POST["h_q2"];
    $h_q3 = $_POST["h_q3"];
    $h_q4 = $_POST["h_q4"];
    $h_q5 = $_POST["h_q5"];
    $h_qt = $_SESSION["timecoms"];
    $u_dt = date("Y-m-d H:i:s");

    $sql = "INSERT INTO grida_h_t ";
    $sql.= "(id,h_q1,h_q2,h_q3,h_q4,h_q5,h_qt,u_dt,num)";
    $sql.= " VALUES ";
    $sql.= "('$id', '$h_q1', '$h_q2', '$h_q3', '$h_q4', '$h_q5', '$h_qt', '$u_dt', '$num')";
    $result = mysql_query($sql);



    

    if($result)
    {
      echo "<script>alert('다음 검사를 진행합니다.'); location.href='../htp_test/t_test.html';</script>";
    }
    else
    {
      echo "<script>alert('질문을 다시 적어주세요.'); location.href='../htp_test/h_q.php';</script>";
    }
    mysql_close($connect);

    // 새 글 쓰기인 경우 리스트로..
    //echo ("<meta http-equiv='Refresh' content='1; URL=list.php'>");
    //1초후에 list.php로 이동함.
    
?>
