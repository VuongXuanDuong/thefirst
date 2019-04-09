<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\news_model;

class new_controller extends Controller
{
   public function index(){
       $the_news = news_model::all()->toArray();
       return view('Home')->with('the_news',$the_news);
   }
   public function insert(){
       return view('Insert');
   }
   public function save(Request $rq){
       $s = new news_model();
       $s->title = $rq->title;
       $s->body = $rq->body;
       $s->save();
       return redirect() -> Route('home');
   }
   public  function edit($id){
       $the_news = news_model::all()->toArray();
       $s = news_model::find($id)->toArray();
       return view('Edit',compact('the_news','s'));
   }
   public function save_edit(Request $rq){
       $s = news_model::find($rq->id);
       $s->title = $rq->title;
       $s->body = $rq->body;
       $s->save();
       return redirect() -> Route('home');
   }
   public function delete($id){
       news_model::find($id)->delete();
       return redirect() -> Route('home');
   }
   public function search(Request $rq){
       $search = $rq -> get('search');
       $s = news_model::where('title','like','%'.$search.'%');
       $s->title = $rq->title;
       $s->body = $rq->body;
       $s->save();
       return view('Home')->with('the_news',$s);
   }

}
