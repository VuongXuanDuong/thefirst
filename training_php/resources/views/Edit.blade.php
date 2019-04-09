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
    <form  action="{{Route('save_edit')}}"  method="POST">
        {{ csrf_field() }}
        <input type="hidden" name="id" value="{{$s['id']}}">
        Title: <br>
        <input type="text" name="title" value="{{$s['title']}}"><br>
        Body: <br>
{{--        <input type="text" name="body" value="{{$s['body']}}"><br>--}}
        <textarea name="body"  rows="10" cols="30">{{$s['body']}}</textarea></br>
        <button type="submit" >OK</button><br>
    </form>

</body>
</html>