<?php
    
    include 'connectdb.php';
    require 'header.php';

    $retrieveAllDataFromDatabase = mysqli_query($connectionToDatabase, "SELECT * FROM users");
?>


<h1 style= "text-align: center;">REGISTERED USERS</h3>
<table>
    <thead>
        <tr>
            <th>ID</th>
            <th>First name</th>
            <th>Middle name</th>
            <th>Last name</th>
            <th>Email</th>
            <th>Age</th>
            <th>Sex</th>
            <th>Date Of Birth</th>
            <th colspan="2">Actions</th>
        </tr>
    </thead>

    <?php
        while ($row = mysqli_fetch_assoc($retrieveAllDataFromDatabase)) {
            $id = $row['id'];
            $firstName = $row['firstName'];
            $middleName = $row['middleName'];
            $lastName = $row['lastName'];
            $email = $row['email'];
            $age = $row['age'];
            $sex = $row['sex'];
            $dateOfBirth = $row['dateOfBirth'];
               
    ?>
    <tbody>
        <tr>
            <td><a href="detailed_view.php?GetId=<?php echo $id; ?>"><button><?php echo $id; ?></button></a></td>
            <td><?php echo $firstName; ?></td>
            <td><?php echo $middleName; ?></td>
            <td><?php echo $lastName; ?></td>
            <td><?php echo $email; ?></td>
            <td><?php echo $age; ?></td>
            <td><?php echo $sex; ?></td>
            <td><?php echo $dateOfBirth; ?></td>
            <td><a href="edit.php?GetId=<?php echo $id;?>"><button>Edit</button></a></td>
            <td><a href="delete.php?Delete=<?php echo $id;?>"><button>Delete</button></a></td>
        </tr>
    </tbody>

<?php } ?>
       
</table>
<br>

<a href="index.php"><button style= "text-align: center;">Add New User</button></a>
    
<style type="text/css">
    table {
        border-collapse: collapse;
        width: 100%;
        text-align: center;
    }
    table th, td{
        border: 1px solid #121826;
    }
    table img{
        width: 20%;
        border-radius: 25%;
        border: 2px solid #2f4f4f;
    }
</style>

<?php require 'footer.php'; ?>
