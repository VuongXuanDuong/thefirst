<?php

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/',['as'=>'home','uses'=>'new_controller@index']);
Route::get('/insert','new_controller@insert');
Route::post('/save',['as'=>'save','uses'=> 'new_controller@save']);
Route::get('/edit/{id}','new_controller@edit');
Route::post('/save_edit',['as'=>'save_edit','uses'=>'new_controller@save_edit']);
Route::get('/delete/{id}','new_controller@delete');
Route::get('/search',['as'=>'search','uses'=>'new_controller@search']);

