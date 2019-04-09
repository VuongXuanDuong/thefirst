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

    <?php
    //var_dump($the_news)
    ?>
    <h1>Danh sách tin tức</h1>
    <form action=" " method="get">
        <input type="search" name="search">
        <button type="submit">SEARCH</button>

    </form>
    <table border="1">

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
            <?php $stt=0;foreach ($the_news as $value):$stt++ ?>
            <tr>
                <td>{{$stt}}</td>
                <td>{{$value['title']}}</td>
                <td>{{$value['body']}}</td>
                <td><a href="edit/{{$value['id']}}">Edit</a> </td>
                <td><a href="delete/{{$value['id']}}">Delete</a> </td>
            </tr>
            <?php endforeach;?>
        </tbody>

    </table>
    <a href="insert">Thêm Tin Mới</a>
</body>
</html>