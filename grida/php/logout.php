<!doctype html>
<head>
    <title>그리다</title>
   <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0, user-scalable=no">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  </head>
 <body>
<?php session_start();?>
<?php

SESSION_DESTROY();

echo "<script>alert('로그아웃 되었습니다.'); document.location.href='../index.php';</script>";
?>
</body>
</html>