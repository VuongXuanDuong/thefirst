<!doctype html>
<html lang="en">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Thêm tin tức</title>
</head>
<body>
    <form action="{{Route('save')}}"  method="POST">
        {{ csrf_field() }}
        Title: <br>
        <input type="text" name="title" placeholder="Thêm tiêu đề"><br>
        Body: <br>
{{--        <input type="text" name="body"><br>--}}
        <textarea name="body" rows="10" cols="30" placeholder="Thêm nội dung"></textarea><br>
        <button type="submit">OK</button>
    </form>

</body>
</html>