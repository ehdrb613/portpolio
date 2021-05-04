<?
    
    include $_SERVER["DOCUMENT_ROOT"]."php/global.php"; 
    session_start();


    $id = $_SESSION["myAdmin"];

    $h_q1 = $_POST["h_q1"];
    $h_q2 = $_POST["h_q2"];
    $h_q3 = $_POST["h_q3"];
    $h_q4 = $_POST["h_q4"];
    $h_q5 = $_POST["h_q5"];
    $h_q6 = $_POST["h_q6"];
    $h_qt = "2017-03-27 14:26:33"; //임의값
    $h_dt = "2017-03-27 14:26:33"; //임의값


    //if(isset($_GET["timecom"]))
    //{
        //$timecom = $_GET["timecom"];
       // echo "Y";
    //}
    $connect = mysql_connect("localhost", "cozco2", "cell2242");
    mysql_select_db("cozco2",$connect);
    mysql_query("set names utf8");

    $sql = "INSERT INTO grida_h_t ";
    $sql.= "(id,h_q1,h_q2,h_q3,h_q4,h_q5,h_q6)";
    $sql.= " VALUES ";
    $sql.= "('$id', '$h_q1', '$h_q2', '$h_q3', '$h_q4', '$h_q5', '$h_q6')";
    $result = mysql_query($sql);

    if($result)
    {
      echo $id."님 등록 되었습니다.";
    }
    else
    {
      echo $id."님 등록이 되지않습니다.";
    }

    echo $id.$h_q1.$h_q2.$h_q3.$h_q4.$h_q5.$h_q6;
    mysql_close($connect);


    // 새 글 쓰기인 경우 리스트로..
    //echo ("<meta http-equiv='Refresh' content='1; URL=list.php'>");
    //1초후에 list.php로 이동함.
?>
