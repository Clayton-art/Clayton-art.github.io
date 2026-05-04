<?php
    $connectionToDatabase = mysqli_connect("localhost", "root", "", "crud");


    if(!$connectionToDatabase){
        die("Connection Failed. ". mysqli_connect_error());
    }
?>

