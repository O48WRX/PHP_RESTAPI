<?php

require_once("connection.php");
require_once("common.php");
$db = new dbObj();
$connection = $db->getConnection();

// HTTP METHODS HASZNÁLATA

$request = $_SERVER['REQUEST_METHOD'];

switch ($request) {
	case "GET":
		if(!empty($_GET["id"])){
            $id = intval($_GET["id"]);
            $data = get_ticket_by_id($id);
            echo json_encode($data);
        }else
            $data = get_all_tickets();
            echo json_encode($data);
		break;
	case "POST":
		$content = file_get_contents('php://input');
		$data = json_decode($content, true);
		insert_ticket($data["ticket_id"],$data["movie_id"],$data["movie_title"],$data["stream_time"]);
		break;
	case "PUT":
		$content = file_get_contents('php://input');
		$data = json_decode($content, true);
		update_ticket($data["ticket_id"], $data["movie_id"], $data["movie_title"], $data["stream_time"]);
		break;
	case "DELETE":
		$content = file_get_contents('php://input');
		$data = json_decode($content, true);
		delete_ticket($data["id"]);
		break;
	default:
		header('HTTP/1.1 405 Method Not Allowed');
		header('Allow: GET, POST, PUT, DELETE');
		break;
}

function get_all_tickets(){
    global $connection;
    
    // Perform query
    $result = $connection -> query("SELECT ticket_id, movie_id, movie_title, stream_time FROM tickets");
    
    return $result->fetch_all(MYSQLI_ASSOC);
}

function get_ticket_by_id($id=0){
    global $connection;
    
    // Perform query
    $result = $connection -> query("SELECT ticket_id, movie_id, movie_title, stream_time FROM tickets WHERE ticket_id = '$id'");
    
    return $result->fetch_all(MYSQLI_ASSOC);
}

function insert_ticket($ticketId, $MovieId, $movieTitle, $streamTime) {
	global $connection;
	
	// Perform query
	$result = $connection -> query("INSERT INTO tickets SET ticket_id = '$ticketId', movie_id = '$MovieId', movie_title = '$movieTitle', stream_time = '$streamTime'");
}

function update_ticket($ticketId, $MovieId, $movieTitle, $streamTime) {
	global $connection;

	// Perform query
	$connection -> query("UPDATE tickets SET ticket_id ='$ticketId', movie_id ='$MovieId', movie_title ='$movieTitle' WHERE ticket_id ='$ticketId'");
}

function delete_ticket($ticketId) {
	global $connection;
	
	// Perform query
	$connection -> query("DELETE FROM tickets WHERE ticket_id = '$ticketId'");
}
?>