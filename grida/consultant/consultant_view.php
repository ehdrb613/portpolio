<?php
session_start();

function g($v){
	if(isset($_GET["$v"])){
		return $_GET["$v"];
	}
	return "";
}
$ord = g("ord");

$connect = mysql_connect("localhost", "cozco2", "cell2242");
    mysql_select_db("cozco2",$connect);
    mysql_query("set names utf8");

    

	if(g("mode") =="del"){
	$id=$_GET["id"];
	$sql = "DELETE FROM grida_h_t WHERE id='$id'";
	mysql_query($sql);
}

?>
<!DOCTYPE html>
<html>
<head>
	<title>그리다</title>
	<meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0, user-scalable=no">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<link href="../css/storage_style.css" rel="stylesheet" type="text/css"/>

	<script type="text/javascript">
		function del(i){
			if(confirm('정말로??')){
				location.href="?mode=del&ord=<?php echo $ord?>&id="+i;
			}
		}
	</script>
</head>
<body>
	
	<header>
    <div id="return">
    <a href="storage.php">
      <img src="../img/화살표2.png"/>
    </a>
    </div>
    <div id="rogo"><img src="../img/logowhite.png"></div>
    <div id="title">보관함</div>
     </header>
	<table>
		
<?php
	$v_id = $_SESSION["myAdmin"];
	$a=0;

	if ($_SESSION["myAdmin"] == "counselor1")
	{
		$cl_name = "손혜주";
	}
	else if ($_SESSION["myAdmin"] == "counselor2")
	{
		$cl_name = "상담사추가";
	}
	$num = $_GET["v_num"];
	//여기에 select 쪽에 세션 받아서 id 비교하는거 넣어야됨
	
	/*
	if($ord == "asc"){
		$sql = "SELECT * FROM grida_h_t WHERE id='$v_id' ORDER BY sum ASC";
	}
	if($ord == "desc"){
		$sql = "SELECT * FROM grida_h_t WHERE id='$v_id' ORDER BY sum DESC";
	}
	*/
	
?>
		<tr>
				<td>
				<!--이미지 넣을곳-->
				<div> H검사 </div>
				<?php

 		
        $sql2 = "SELECT id FROM grida_h_t WHERE ok = '미등록'";
        $result2 = mysql_query($sql2);
      	$row = mysql_fetch_assoc($result2);
            $fn_v=$row["fn"];
        
?>


    <img class="img_size" src="../t_img/h_t_img/<?php echo $fn_v; ?>">

				</td>
		</tr>

		<?php
		$sql= "SELECT * FROM grida_h_t WHERE ok = '미등록' && num='$num'";
		$result = mysql_query($sql);//h검사 내용

		if($result){
		while($row = mysql_fetch_assoc($result)){
			?>

		<tr>
				<td>
				<div class="view_text">
				<div>Q1 :<?php echo $row["h_q1"]?></div>
				<div>Q2 :<?php echo $row["h_q2"]?></div>
				<div>Q3 :<?php echo $row["h_q3"]?></div>
				<div>Q4 :<?php echo $row["h_q4"]?></div>
				<div>Q5 :<?php echo $row["h_q5"]?></div>
				<div>Q6 :<?php echo $row["h_q6"]?></div>
				</div>
				</td>
		</tr>	
		
<?php

		}
	}
?>
	
		<tr>
				<td>
				<!--이미지 넣을곳-->
				<div> T검사 </div>
				<?php
				$sql2 = "SELECT * FROM grida_t_t WHERE id = '$v_id' && num ='$num'";
        $result2 = mysql_query($sql2);
      	$row = mysql_fetch_assoc($result2);
            $fn_v=$row["fn"];
            ?>
            	<img class="img_size" src="../t_img/t_t_img/<?php echo $fn_v; ?>">
				</td>
		</tr>
		<?php
			$sql= "SELECT * FROM grida_t_t WHERE id='$v_id' && num='$num'";

			$result = mysql_query($sql);//h검사 내용
			if($result){
			while($row = mysql_fetch_assoc($result)){
		?>
		<tr>
				<td>
				<div class="view_text">
				<div>Q1 :<?php echo $row["t_q1"]?></div>
				<div>Q2 :<?php echo $row["t_q2"]?></div>
				<div>Q3 :<?php echo $row["t_q3"]?></div>
				<div>Q4 :<?php echo $row["t_q4"]?></div>
				<div>Q5 :<?php echo $row["t_q5"]?></div>
				<div>Q6 :<?php echo $row["t_q6"]?></div>
				<div>Q7 :<?php echo $row["t_q7"]?></div>
				<div>Q8 :<?php echo $row["t_q8"]?></div>
				</div>
				</td>
		</tr>	
		
<?php

		}
	}

	
?>
		<tr>
				<td>
				<!--이미지 넣을곳-->
				<div> P1검사 </div>
				<?php
				$sql2 = "SELECT * FROM grida_p_t1 WHERE id = '$v_id' && num ='$num'";
        	$result2 = mysql_query($sql2); 
      		$row = mysql_fetch_assoc($result2);
            $fn_v=$row["fn"];
            ?>
            	<img class="img_size" src="../t_img/p1_t_img/<?php echo $fn_v; ?>">
				</td>
		</tr>
		<?php
		$sql= "SELECT * FROM grida_p_t1 WHERE id='$v_id' && num='$num'";

		$result = mysql_query($sql);//h검사 내용
			if($result){
			while($row = mysql_fetch_assoc($result)){
			?>
		<tr>
				<td>
				<div class="view_text">
				<div>Q1 :<?php echo $row["p_q1"]?></div>
				<div>Q2 :<?php echo $row["p_q2"]?></div>
				<div>Q3 :<?php echo $row["p_q3"]?></div>
				<div>Q4 :<?php echo $row["p_q4"]?></div>
				<div>Q5 :<?php echo $row["p_q5"]?></div>
				<div>Q6 :<?php echo $row["p_q6"]?></div>
				<div>Q7 :<?php echo $row["p_q7"]?></div>
				</div>
				</td>
		</tr>	
		
<?php

		}
	}
?>

		<tr>
				<td>
				<!--이미지 넣을곳-->
				<div> P2검사 </div>
				<?php
				$sql2 = "SELECT * FROM grida_p_t2 WHERE id = '$v_id' && num ='$num'";
        $result2 = mysql_query($sql2);
      	$row = mysql_fetch_assoc($result2);
            $fn_v=$row["fn"];
            ?>
            	<img class="img_size" src="../t_img/p2_t_img/<?php echo $fn_v; ?>">
				</td>
		</tr>
		<?php
		$sql= "SELECT * FROM grida_p_t2 WHERE id='$v_id' && num='$num'";

		$result = mysql_query($sql);//h검사 내용
			if($result){
			while($row = mysql_fetch_assoc($result)){
			?>
		<tr>
				<td>
				<div class="view_text">
				<div>Q1 :<?php echo $row["p_q1"]?></div>
				<div>Q2 :<?php echo $row["p_q2"]?></div>
				<div>Q3 :<?php echo $row["p_q3"]?></div>
				<div>Q4 :<?php echo $row["p_q4"]?></div>
				<div>Q5 :<?php echo $row["p_q5"]?></div>
				<div>Q6 :<?php echo $row["p_q6"]?></div>
				<div>Q7 :<?php echo $row["p_q7"]?></div>
				</div>
				</td>
		</tr>	
		
<?php

		}
	}
?>



	<input id="qu" class="bu" type="button" value="답변" />
	</table>
	 
</body>
</html>
<?php
mysql_close($connect);

?>