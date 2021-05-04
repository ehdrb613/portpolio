<?php

    include $_SERVER["DOCUMENT_ROOT"]."php/global.php"; 
    session_start();

    if(isset($_GET["timecom"]))
    {
        $timecom = $_GET["timecom"];
        echo "<script>alert('소요시간은 ' + time + ' 입니다.');</script>";
        $_SESSION["timecoms"] = "$timecom ";
    }
    else
    {
    	echo "<script>alert('소요시간은 ' + time + ' 입니다.');</script>";
    	$_SESSION["timecoms"] = "$timecom ";
    }

?>