<?
    
    include $_SERVER["DOCUMENT_ROOT"]."php/global.php"; 
    session_start();

$random = rand(1,2);

if($random == 1)
{
    $c_name = "counselor1";
}
else
{
    $c_name = "counselor2";
}



    $id = $_SESSION["myAdmin"];
    $fn =$_SESSION["fn"];

    $h_q1 = $_POST["h_q1"];
    $h_q2 = $_POST["h_q2"];
    $h_q3 = $_POST["h_q3"];
    $h_q4 = $_POST["h_q4"];
    $h_q5 = $_POST["h_q5"];
    $h_qt = $_SESSION["timecoms"];
    $u_dt = date("Y-m-d H:i:s");

    $connect = mysql_connect("localhost", "cozco2", "cell2242");
    mysql_select_db("cozco2",$connect);
    mysql_query("set names utf8");

    $sql = "INSERT INTO grida_h_t ";
    $sql.= "(id,h_q1,h_q2,h_q3,h_q4,h_q5,h_qt,u_dt,fn,c_name,ok)";
    $sql.= " VALUES ";
    $sql.= "('$id', '$h_q1', '$h_q2', '$h_q3', '$h_q4', '$h_q5', '$h_qt', '$u_dt', '$fn', '$random', '미등록')";
    $result = mysql_query($sql);


    if($result)
    {
      $sql = "INSERT INTO grida_htp ";
      $sql.= "(u_id,h,t,p1,p2,c_name)";
      $sql.= " VALUES ";
      $sql.= "('$id', 'Y', 'N', 'N', 'N', '$c_name')";
      $result = mysql_query($sql);
      echo $random;
      echo "<script>alert('다음 검사를 진행합니다.'); location.href='../htp_test/t_test.html';</script>";
      
      


    }
    else
    {
      echo "<script>alert('질문을 다시 적어주세요.'); location.href='../htp_test/h_q.html';</script>";
    }

    // 새 글 쓰기인 경우 리스트로..
    //echo ("<meta http-equiv='Refresh' content='1; URL=list.php'>");
    //1초후에 list.php로 이동함.
    
?>
