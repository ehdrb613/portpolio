<?php

if(isset($_GET["confirm"]))
{
	$confirm = $_GET["confirm"];

    $connect = mysql_connect("localhost", "cozco2", "cell2242");
    mysql_select_db("cozco2",$connect);
    mysql_query("set names utf8");
    
    $sql = "SELECT e_confirm FROM grida_member WHERE e_confirm = '$confirm'";
    $result=mysql_query($sql);
    $count=mysql_num_rows($result);

    if($count==1)
    {
    	$sql="UPDATE grida_member SET flag = 'true' WHERE e_confirm = '$confirm'";
    	$result = mysql_query($sql);
    	echo "Y";
    	mysql_close($connect);
    }
    else
    {
    	echo "N";
    }
}

?>
