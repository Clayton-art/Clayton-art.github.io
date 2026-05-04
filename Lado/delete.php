<?php

    include 'connectdb.php';


    if (isset($_GET['Delete'])) {
        $id = $_GET['Delete'];


        $deleteSpecificUser = mysqli_query($connectionToDatabase, "DELETE FROM users WHERE id = $id");


        if ($deleteSpecificUser) {
            header("Location: view.php");
        } else {
            echo "User was not deleted. Please check your query.";
        }
    } else {
        echo "Query Failed.";
    }

?>
