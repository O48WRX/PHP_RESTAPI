<?php
include("connection.php");
include("loggedin.php")

$db = new dbObj();
$connection = $db->getConnection();
$request_method = $_SERVER["REQUEST_METHOD"];

switch($request_method){
    case 'GET':         
        if(!empty($_GET["id"])){
            $id = intval($_GET["id"]);
            get_movie_by_id($id);
        }else
            get_all_movies();
    break;
    
    case 'POST':
        insert_movie();       
    break;
    
    case 'PUT': 
        update_movie();
    break;
    
    case 'DELETE': 
        $id = intval($_GET["id"]);
        delete_movie($id);
    break;
    
    default:
        header("HTTP/1.0 405 Method Not Allowed");
    break;
}

function get_all_movies(){
    global $connection;
    $query = "SELECT * FROM movie";

    $response = array();
    $result = mysqli_query($connection, $query);
    while($row=mysqli_fetch_assoc($result)) 
        $response[] = $row;

    header('Content-Type: application/json');
    echo json_encode($response);
}

function get_movie_by_id($id=0){
    global $connection;
    $query = "SELECT * FROM movie";
    if($id != 0) $query.= " WHERE id =" . $id . " LIMIT 1"; 
    $response = array();
    $result = mysqli_query($connection, $query);
    while($row=mysqli_fetch_assoc($result)) 
        $response[] = $row;

    header('Content-Type: application/json');
    echo json_encode($response);
}

function insert_movie(){
    global $connection;
    $data = json_decode(file_get_contents('php://input'), true);
    $user = checkLoggedIn($data["username"], $data["password"]);
    if (!$user or !$user["isAdmin"]) {
        header('HTTP/1.0 401 Unauthorized ');
        break;
    }

    $reqid = $data["id"];
    $reqtitle = $data["title"];
    
    $query="INSERT INTO movie SET id='".$reqid."', title='".$reqtitle."'";

    if(mysqli_query($connection, $query)){
        $response = array(
        'status' => 1,
        'status_message' => 'Movie inserted successfully'
        );
    }else{
        $response = array(
            'status' => 0,
            'status_message' => 'Movie insertion failed'
        );
    }
        
    header('Content-Type: application/json');

    echo json_encode($response); 
}

function update_movie(){
    global $connection;
    $data = json_decode(file_get_contents('php://input'),true);
    $user = checkLoggedIn($data["username"], $data["password"]);
    if (!$user or !$user["isAdmin"]) {
        header('HTTP/1.0 401 Unauthorized ');
        break;
    }

    $reqid = $data["id"];
    $reqtitle = $data["title"];

    $query = "UPDATE movie SET id='".$reqid."', title='".$reqtitle."'";

    if(mysqli_query($connection, $query)){
        $response = array(
            'status' => 1,
            'status_message' => 'Movie updated successfully'
        );
    } else {
        $response = array(
            'status' => 0,
            'status_message' => 'Movie update failed'
        );
    }
    header('Content-Type: application/json');

    echo json_encode($response);
}

function delete_movie($id){
    global $connection;

    $data = json_decode(file_get_contents('php://input'), true);
    $user = checkLoggedIn($data["username"], $data["password"]);
    if (!$user or !$user["isAdmin"]) {
        header('HTTP/1.0 401 Unauthorized ');
        break;
    }

    $query = "DELETE FROM movie WHERE id = ".$id;

    if(mysqli_query($connection, $query)){
        $response = array(
        'status' => 1,
        'status_message' => 'Car deleted successfully'
        );
    }else{
        $response = array(
            'status' => 0,
            'status_message' => 'Car deletion failed'
        );
        header("Content-Type: application/json");
    }

    echo json_encode($response);
}

?>