<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class category_model extends Model
{
    protected $table='category_table';
    public $timestamps = false;
    public function theNew(){
        return $this->hasMany(App\news_model,'id_cate','id');
    }
}
