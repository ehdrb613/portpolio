<?php

    include $_SERVER["DOCUMENT_ROOT"]."php/global.php"; 
    session_start();

    if(isset($_GET["timecom"]))
    {
        $timecom = $_GET["timecom"];
        echo "Y";
        $_SESSION["timecoms"] = "$timecom ";
    }
    else
    {
    	echo "N";
    	$_SESSION["timecoms"] = "$timecom ";
    }

?>