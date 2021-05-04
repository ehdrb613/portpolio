<?php
    session_start();
    $id = $_SESSION["myAdmin"];

    $connect = mysql_connect("localhost", "cozco2", "cell2242");
    mysql_select_db("cozco2",$connect);
    mysql_query("set names utf8");

    $a = 0;
    $sql = "SELECT * FROM grida_imege WHERE id = '$id'";
    $result = mysql_query($sql);
    $count = mysql_num_rows($result);
    echo $count;
    if($count > 0)
    {
        $sql = "SELECT * FROM grida_h_t WHERE id = '$id'";
        $result1 = mysql_query($sql);
        while($row = mysql_fetch_assoc($result1))
        {

            $fn_v[$a]=$row["fn"];
            echo $fn_v[$a];
            $a++;

        }
    }
    $a = 0;



?>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>h검사</title>

   <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0, user-scalable=no">
<meta http-equiv="Content-type" content="text/html; charset=utf-8">
</head>
<body>
    <img src="../t_img/h_t_img/<?php echo $fn_v[$a]; ?>">
</body>
</html>