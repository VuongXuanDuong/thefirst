<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Danh sách tin tức</title>
</head>
<body>

<h1 id="h11">DANH SÁCH TIN TỨC</h1>
<h2>
    <form action=" " method="get" id="form1">
        <button type="submit">SEARCH</button>
        <input type="search" name="search" value="{{ isset($_GET['search']) ? $_GET['search'] : ''}}">

    </form>
</h2>
<table border="1" id="customers">

    <thead>
    <tr>
        <th>STT</th>
        <th>Title</th>
        <th>Body</th>
        <th>Delete</th>
        <th>Edit</th>
    </tr>
    </thead>
    <tbody>
    <?php $stt=0;foreach ($s as $s):$stt++ ?>
    <tr>
        <td>{{$stt}}</td>
        <td>{{$s->title}}</td>
        <td>{{$s->body}}</td>
        <td><a href="edit/{{$s['id']}}">Edit</a> </td>
        <td><a href="delete/{{$s['id']}}">Delete</a> </td>
    </tr>
    <?php endforeach;?>
    </tbody>

</table>
<a href="/training_php/public/">Home</a>
</body>
</html><?php
