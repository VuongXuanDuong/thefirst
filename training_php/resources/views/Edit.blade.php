<!doctype html>
<html lang="en">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Thêm tin tức</title>
    <style>
        input[type=text], select {
            width: 50%;
            padding: 12px 20px;
            margin: 8px 0;
            display: inline-block;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
        }
        textarea{
            width: 650px;
            height: 350px;
            /*padding: 100px 20px;*/
            /*text-align: left;*/

        }
        button[type=submit] {
            background-color: #4CAF50;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }


        div {
            border-radius: 5px;
            background-color: #f2f2f2;
            padding: 20px;
        }
    </style>
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