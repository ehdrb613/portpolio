<!doctype html>
<head>
</head>
<?php

    session_start();
    $random = $_SESSION["R_session"];
    $id = $_SESSION["I_session"];

    $confirm = $_POST["u_confirm"];

    $connect = mysql_connect("localhost", "cozco2", "cell2242");
    mysql_select_db("cozco2",$connect);
    mysql_query("set names utf8");
    
    $sql = "UPDATE grida_member SET flag = 'true' WHERE e_confirm = '$confirm'";
    $result=mysql_query($sql);
    $count=mysql_num_rows($result);

    if($count==1)
    {
        echo "인증되었다.";
    }
    else
    {
        echo "인증되지않았다.";
    }


?>
