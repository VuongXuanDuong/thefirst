<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class news_model extends Model
{
    protected $table='the_news';
    public $timestamps = false;
    public function category(){
        return $this->belongsTo('App\category_model','id_cate','id');
    }

}
