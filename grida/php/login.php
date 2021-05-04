<?php

    $id = $_POST["u_id"];
    $pw = $_POST["u_pw"];

    $connect = mysql_connect("localhost", "cozco2", "cell2242");
    mysql_select_db("cozco2",$connect);
    mysql_query("set names utf8");

    $sql = "SELECT id FROM grida_member WHERE id = '$id'";
    $result = mysql_query($sql);
    $count = mysql_num_rows($result);

    if($count == 1)
    {
        $sql = "SELECT pw FROM grida_member WHERE pw = '$pw' and id ='$id'";
        $result = mysql_query($sql);
        $count = mysql_num_rows($result);

        if($count == 1)
        {
            $sql = "SELECT flag FROM grida_member WHERE flag = 'true' and id ='$id'";
            $result = mysql_query($sql);
            $count = mysql_num_rows($result);

            if($count == 1)
            {
                        session_start();
                        $_SESSION["myAdmin"] = "$id";
                        echo "<script>alert('로그인되었습니다.'); document.location.href='../index.php';</script>";
            }
            else
            {
                echo "<script>alert('이메일인증이 되지않았습니다. 인증페이지로 넘어갑니다.'); document.location.href='../php/meil_confirm.php';</script>";
            }
        }
        else
        {
            
            echo "<script>alert('비밀번호가 틀립니다.'); document.location.href='../sub/login.html';</script>";
        }
    }
    else
    {
        echo "<script>alert('존재하지 않는 회원입니다. 아이디를 확인해주세요.'); document.location.href='../sub/login.html';</script>";
    }



?>


       