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
            $table->String('body');
        });
    }


    public function down()
    {
        Schema::dropIfExists('the_news');
    }
}
