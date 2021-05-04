<?php
    $connect = mysql_connect("localhost", "cozco2", "cell2242");
    mysql_select_db("cozco2",$connect);
    mysql_query("set names utf8");
?>

<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8" />
	<title>자유게시판</title>
	<link rel="stylesheet" href="../css/normalize_style.css" />
	<link rel="stylesheet" href="../css/board_style.css" />
</head>
<body>
	<article class="boardArticle">
		<h3>자유게시판</h3>
		<table>
			<caption class="readHide">자유게시판</caption>
			<thead>
				<tr>
					<th scope="col" class="no">번호</th>
					<th scope="col" class="title">제목</th>
					<th scope="col" class="author">작성자</th>
					<th scope="col" class="date">작성일</th>
					<th scope="col" class="hit">조회</th>
				</tr>
			</thead>
			<tbody>
					<?php
						$sql = 'select * from board order by no desc';
						$result = $db->query($sql);
						while($row = $result->fetch_assoc())
						{
							$datetime = explode(' ', $row['date']);
							$date = $datetime[0];
							$time = $datetime[1];
							if($date == Date('Y-m-d'))
								$row['b_date'] = $time;
							else
								$row['b_date'] = $date;
					?>
				<tr>
					<td class="no"><?php echo $row['no']?></td>
					<td class="title"><?php echo $row['title']?></td>
					<td class="author"><?php echo $row['id']?></td>
					<td class="date"><?php echo $row['date']?></td>
					<td class="hit"><?php echo $row['hit']?></td>
				</tr>
					<?php
						}
					?>
			</tbody>
		</table>
	</article>
</body>
</html>