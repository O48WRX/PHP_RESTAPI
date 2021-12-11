<?php
require_once("connection.php");
require_once("common.php");

$db = new dbObj();
$connection = $db->getConnection();
$request_method = $_SERVER["REQUEST_METHOD"];

switch($request_method){
    case 'GET':         
        if(!empty($_GET["id"])){
            $id = intval($_GET["id"]);
            $data = get_movie_by_id($id);
            echo json_encode($data);
        }else
            $data = get_all_movies();
            echo json_encode($data);
    break;
    case 'POST':
        $content = file_get_contents('php://input');
        $data = json_decode($content, true);
        $user = checkLoggedIn($data["username"], $data["password"]);
        $admin = checkAdmIn($data["username"], $data["password"]);
        if(!$user or !$admin){
            header('HTTP/1.0 401 Unauthorized ');
            break;
        }
        insert_movie($data["title"]);
    break;
    
    case 'PUT': 
        $content = file_get_contents('php://input');
        $data = json_decode($content, true);
        $user = checkLoggedIn($data["username"], $data["password"]);
        $admin = checkAdmIn($data["username"], $data["password"]);
        if(!$user or !$admin){
        header('HTTP/1.0 401 Unauthorized ');
        break;
        }
        update_movie($data["title"], $data["id"]);
    break;
    
    case 'DELETE': 
        $content = file_get_contents('php://input');
        $data = json_decode($content, true); // asszociatív tömb
        $user = checkLoggedIn($data["username"], $data["password"]);
        $admin = checkAdmIn($data["username"], $data["password"]);
        if(!$user or !$admin){
        header('HTTP/1.0 401 Unauthorized ');
        break;
        }
        delete_movie($data["id"]);
    break;
    
    default:
        header('HTTP/1.1 405 Method Not Allowed');
        header('Allow: GET, POST, PUT, DELETE');
    break;
}

function get_all_movies(){
    global $connection;
    
    // Perform query
    $result = $connection -> query("SELECT id, title FROM movie");
    
    return $result->fetch_all(MYSQLI_ASSOC);
}

function get_movie_by_id($id=0){
    global $connection;
    
    // Perform query
    $result = $connection -> query("SELECT id, title FROM movie WHERE id = '$id'");
    
    return $result->fetch_all(MYSQLI_ASSOC);
}

function insert_movie($title){
    global $connection;
    
    // Perform query
    $result = $connection -> query("INSERT INTO movie SET title = '$title'");
}

function update_movie($title, $id){
    global $connection;

    // Perform query
    $connection -> query("UPDATE movie SET title = '$title' WHERE id = '$id'");
}

function delete_movie($id){
    global $connection;

    // Perform query
    $connection -> query("DELETE FROM movie WHERE id = '$id'");
}

?>