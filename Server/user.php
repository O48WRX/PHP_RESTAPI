<?php

include("connection.php");

// HTTP METHODS HASZNÁLATA

$request = $_SERVER['REQUEST_METHOD'];

switch ($request) {
	case "GET":
		if (!empty($_GET["username"])) {
			$users = login($_GET["username"], $_GET["password"]);
		}
		else {
			$users = getUsers();
		}
		echo json_encode($users);
		break;
	case "POST":
		if (!empty($_GET["username"])) {
			$user = checkLoggedIn($_GET["username"], $_GET["password"]);
			if (!empty($user)) {
				insert_user();
			}
			else {
				header("HTTP/1.0 401 Unauthorized");
			}
		}
		echo json_encode($user);
		break;
	case "PUT":
		print("User update-elése");
		break;
	case "DELETE":
		print("User delete-elése");
		break;
	default:
		header('HTTP/1.1 405 Method Not Allowed');
		header('Allow: GET, POST, PUT, DELETE');
		break;
}

function login($u, $p) {
	global $connection;
	
	// Perform query
	$result = $connection -> query("SELECT id, name, password, isAdmin FROM user WHERE name = '".$u."' AND password = '".$p."'");
	
	return $result->fetch_all(MYSQLI_ASSOC)[0];
}

function getUsers(){
	global $connection;
	$query = "SELECT * FROM user";

	$response = array();
	$result = mysqli_query($connection, $query);
	while($row=mysqli_fetch_assoc($result)) {
		$response[] = $row;
	}

	header('Content-Type: application/json');
	echo json_encode($response);
}

function insert_user() {
	global $connection;
	$data = json_decode(file_get_contents('php://input'), true);

	$reqid = $data["id"];
	$reqname = $data["name"];
	$reqpassword = $data["password"];
	$reqadmin = $data["isAdmin"];

	$query="INSERT INTO user SET id='".$reqid."', name='".$reqname."', password='".$reqpassword."', isAdmin='".$reqadmin."'";

	if(mysqli_query($connection, $query)){
        $response = array(
        'status' => 1,
        'status_message' => 'User inserted successfully'
        );
    }else{
        $response = array(
            'status' => 0,
            'status_message' => 'User insertion failed'
        );
    }
    header('Content-Type: application/json');
}

function update_user() {
	global $connection;

	$data = json_decode(file_get_contents('php://input'), true);

	$reqid = $data["id"];
	$reqname = $data["name"];
	$reqpassword = $data["password"];
	$reqadmin = $data["isAdmin"];

	$query1 = "SELECT * from user WHERE id='".$reqid."' LIMIT 1";
	if(mysqli_query($connection, $query1)){
        $query = "UPDATE user SET id='".$reqid."', name='".$reqname."', password='".$reqpassword."', isAdmin='".$reqadmin."'";

        if(mysqli_query($connection, $query)){
            $response = array(
                'status' => 1,
                'status_message' => 'User updated successfully'
            );
        }else{
            $response = array(
                'status' => 0,
                'status_message' => 'User update failed'
            );
        }
    }else{
        $response = array(
            'status' => 0,
            'status_message' => 'User not found'
        );
    }
}

function checkLoggedIn($u, $p) {
	global $connection;
	
	// Perform query
	$result = $connection -> query("SELECT id, name, password, isAdmin FROM user WHERE name = '".$u."' AND password = '".$p."'");
	
	return $result->fetch_all(MYSQLI_ASSOC)[0];
}

?>