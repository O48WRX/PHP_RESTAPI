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
/*	case "POST":
		print("User insert-elése");
		break;
	case "PUT":
		print("User update-elése");
		break;
	case "DELETE":
		print("User delete-elése");
		break;*/
	default:
		header('HTTP/1.1 405 Method Not Allowed');
		header('Allow: GET, POST, PUT, DELETE');
		break;
}

function login($u, $p) {
	global $connection;
	
	// Perform query
	$result = $con -> query("SELECT id, name, password, isAdmin FROM user WHERE name = '$u' AND password = MD5('$p')");
	
	return $result->fetch_all(MYSQLI_ASSOC)[0];
}

function getUsers(){
	global $connection;
	$query = "SELECT * FROM user"

	$response = array();
	$result = mysqli_query($connection, $query);
	while($row=mysqli_fetch_assoc($result))
		$response[] = $row;

	header('Content-Type: application/json');
	echo json_encode($response);
}

?>