<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Danh sách tin tức</title>
    <style>
        #customers*{
            border-collapse: collapse;
            width: 80%;
        }

        #customers td, #customers th {
            border: 1px solid #ddd;
            padding: 8px;
        }

        #customers tr{background-color: #f2f2f2;}


        #customers th {
            padding-top: 12px;
            padding-bottom: 12px;
            text-align: left;
            background-color: #83C75D;
            color: white;
        }
        #form1 {
            border-collapse: collapse;
            margin-right: 500px;
        }
        #form1 input{
            width: 200px;
            height: 25px;
            box-sizing: border-box;
            border: 2px solid #ccc;
            border-radius: 4px;
            font-size: 12px;
            background-color: white;

        }
        #form1 button{
            background-color: #4CAF50;
            color: white;
            padding: 5px 18px;
            margin: 8px 0;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }
        #h11{
            /*text-align: center;*/
            font-size: 24px;
        }
        h1{
            text-align: left;
        }
    </style>
</head>
<body>
{{--<h1 id="h11">DANH SÁCH TIN TỨC THỂ LOẠI </h1>--}}
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
    @if($stt== 1)
    <h2>Danh Sách Tin {{$s['category']->name}}</h2>
    @endif

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
<a href="http://traininglaravel.com:8888/">Home</a>
</body>
</html>