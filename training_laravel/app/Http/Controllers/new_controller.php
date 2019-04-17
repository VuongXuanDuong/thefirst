<?php

namespace App\Http\Controllers;

use App\category_model;
use Illuminate\Http\Request;
use App\news_model;
use Illuminate\Support\Facades\Input;

class new_controller extends Controller
{
   public function index(){
         $the_news = news_model::with('category')->get();
//       $the_news = news_model::all()->toArray();
//       $cate = category_model::all()->toArray();
       return view('Home')->with('the_news',$the_news);
   }
   public function insert(){
       $cate = category_model::all()->toArray();
       return view('Insert')->with('category',$cate);
   }
   public function save(Request $rq){
       $s = new news_model();
       $s->id_cate=$rq->cate;
       $s->title = $rq->title;
       $s->body = $rq->body;
       $s->save();
       return redirect() -> Route('home');
   }
   public  function edit($id){
       $the_news = news_model::all()->toArray();
       $s = news_model::find($id)->toArray();
//       $the_news = news_model::with('category')->get()
       $c = category_model::all()->toArray();
       return view('Edit',compact('the_news','s'))->with('category',$c);
   }
   public function save_edit(Request $rq){
       $s = news_model::find($rq->id);
       $s->title = $rq->title;
       $s->id_cate=$rq->cate;
       $s->body = $rq->body;
       $s->save();
       return redirect() -> Route('home');
   }
   public function delete($id){
       news_model::find($id)->delete();
       return redirect() -> Route('home');
   }
   public function search(Request $rq){
       $search = $rq -> search;
       $s = news_model::where('title','like',"%$search%")->with('category')->get();

//       $the_news = news_model::with('category')->get()
       return view('Search')->with('s',$s);
   }
   public function category($id_cate){
       //echo $id_cate;
       $s = news_model::where('id_cate','like',"%$id_cate%")->with('category')->get();
       //print_r($s);
       return view('category')->with('s',$s);
   }
}
