<?php

use Illuminate\Support\Facades\Schema;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class TheNews extends Migration
{

    public function up()
    {
        Schema::create('the_news',function (Blueprint $table){
            $table->increments('id');
            $table->String('title');
            $table->text('body');
            $table->integer('id_cate')->unsigned();
//            $table->foreign('id_cate')->references('id')->on('category_table');
        });
    }

    public function down()
    {
        Schema::dropIfExists('the_news');
    }
}
