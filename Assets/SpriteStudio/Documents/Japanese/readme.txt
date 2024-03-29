﻿=============================================================================
 SpriteStudioPlayer for Unity

  お読みください

 Copyright(C) 2003-2013 Web Technology Corp.
=============================================================================

このたびは SpriteStudioPlayer for Unity をご利用いただきまして、誠に
ありがとうございます。
SpriteStudioPlayer for Unity を使用する前に、本テキストをお読みください。


■はじめに

  SpriteStudioPlayer for Unity とは SpriteStudio で作成されたアニメーションデ
  ータを、Unity 上で表示・制御するためのプラグインです。

  プラグインは通常のアセットと同じ要領でUnityプロジェクトにインポートすること
  によりご利用が可能になります。
  
  【重要】
  本アセットおよび本アセットの入力ファイル(ssax)につきましては、今後の機能追加
  は予定されていません。
  運用上問題がない場合は SS5Player for Unity(OPTPiX SpriteStudio 専用)をお試し
  頂くようお願い致します。
  
  SS5Player for Unity ダウンロードURL
  http://www.webtech.co.jp/help/ja/spritestudio/support/tool_sample_download/

■使用方法について

  SpriteStudioPlayer for Unity のインストール方法および使用方法につきましては、
  後述の■収録内容に記載されている usage.txt をご参照ください。
  その後、各ドキュメント類をご確認ください。


■収録内容

	+SpriteStudio/
		+Documents/
			+Japanese/
				readme.txt  : 本テキストです。
				history.txt : 更新履歴です。
				usage.txt   : インストールおよび使用方法です。
				sample.txt  : サンプルの説明です。
				script.txt  : スクリプトのリファレンスです。

		+Editor/		: 本プラグインのエディタクラス群です。
		+Runtime/		: 本プラグインのランタイムクラス群です。
		+Shaders/		: 本プラグインで利用するシェーダ群です。
		+Samples/		: サンプルです。
						  詳しくは sample.txt をご参照ください。


■動作要件

  当プラグインは下記のプラットフォームでのみ動作検証しております。

  ・Windows
  ・Mac
  ・WebPlayer
  ・iPhone 3GS
  ・Android 2.2/3.0

  上記以外のプラットフォームでは現在のところ動作保証いたしかねる事をご了承下さ
  い。

  Unity のバージョンにつきましては3.3以下での動作検証はしておりません。
  当プラグインで利用している機能の一部が旧バージョンのUnityでは未対応の可能性
  があり、エラー等が発生して正しく動作しない可能性があります。
  そのため3.5以上に更新しておいて頂きますようお願い致します。


■用語について

  スプライトオブジェクトと表記した場合、SsSprite スクリプトがアタッチされた
  SpriteStudio アニメーションを再生するために作成されたゲームオブジェクトを指
  します。


■SpriteStudio の本体バージョンについて

  SpriteStudioPlayer for Unity でSpriteStudioのアニメーションデータを使用する
  には、SpriteStudio Ver.4.00.19 以降のバージョンを使用して頂く 必要がございま
  す。
  
  モーションデータを保存する際にファイルの種類は、
  "モーションテキストデータ(*.ssax)"を選択して下さい。
  
  続けて保存オプションのダイアログで、
  
  SpriteStudioPlayer for Unity 用の情報を出力する
  
  にチェックを付けた状態で保存してください。
  
  上記手順で作成されたデータのインポート手順につきましては usage.txt の
  アニメーションデータのインポート手順をご参照ください。


■インストールされているバージョンの確認方法

  Unity のメインウィンドウ上部にある SpriteStudio メニューから About を選択す
  ることでご確認頂けます。

  SpriteStudioPlayer Version がプラグインのバージョンです。
  Ssax File Version は現在プラグインで読み込みが可能な.ssaxファイルの
  バージョンです。


■未対応の機能

  ・ワークスペース(.ssw)の読み込み

  ・シーンデータ(.sss/.sssx)の読み込み

  ・.ssa 形式の読み込み

  ・パレットチェンジアニメーション

  ・サウンドパーツの再現

    読み込みは行われますが機能しておりません。
  
  ・アニメーション設定の情報の反映

    SpriteStudio 上で設定されたスクリーンサイズや余白はUnity上では反映されませ
    ん。
  
    ※上下左右反転フラグがONのパーツ描画時にイメージのみを反転するフラグのみ
      反映されます。

  ・アトリビュート値の継承率

    値を設定しても反映されません。
  
■ご注意

  ・アトリビュート値の継承について
  
    親子継承設定でX座標、Y座標、角度のチェックをOFFにしても、Unity上では常に
    継承される仕様になっております。

  ・親子継承設定の「個別の設定を使用する」について
  
    個別の設定で指定したアトリビュートのチェック状態は、該当アトリビュートのキ
    ーが１つもない状態では .ssax ファイルに保存されない仕様になっています。
    
    SSAXファイルの保存オプションで、「未使用アトリビュートは出力しない」にチェ
    ックを付けた状態で保存すると意図せずキーが省略され個別の継承設定が保存され
    ない可能性があるためご注意下さい。
    
    その場合は先頭に１つだけキーを打つなどして対処して頂くようお願いいたします。

  ・同名のパーツが複数ある場合の注意点

    １モーションデータ内に同じ名前のパーツが複数ある場合 GetPart(string name)
    では最も若いIDのパーツしか取得できません。
    そのため、スクリプトから制御する必要のあるパーツの名前はモーション内で唯一
    の名前を付けるようお願いいたします。

  ・反転フラグの動作の違いについて
    
    SpriteStudio本体の"アニメーション設定"→"その他"にある
    "「左右反転フラグ」～(中略)～イメージのみ表示を反転する"
    のチェックを外している状態で、反転フラグにチェックを付けているパーツの子パ
    ーツにも反転フラグをチェックしている場合の挙動が SpriteStudio本体とUnity上
    で異なります。
    Unity上での挙動は常に、"親子継承設定"→"個別の設定を使用する"→反転フラグ
    にチェックが付いた状態のものと同じになります。

  ・カラーブレンドアニメが適用された半透明パーツの表示について
  
    カラーブレンドアニメが適用されている半透明パーツは OpenGL ES 1.x 環境
    （初期型のiPhone/Android端末）では不透明度が無視されます。

    これはカラーブレンドの強度パラメータとパーツが持つ不透明度を同時に扱うため
    に CgProgram を利用しており、OpenGL ES 1.x 環境ではこれに対応していないこ
    とが原因です。
  
    そのため、アニメーションデータの作成時にご留意頂ますようよろしくお願い致し
    ます。
  

  ・SpriteStudioPlayer for Unity βバージョンからの上書き更新について

    Ver.0.72 以下のバージョンから更新する場合は下記にご注意ください。
  
    SpriteStudioPlayer for Unity Ver.0.73 以降では、データ管理構造を一部変更さ
    せていただきました。そのため、作成済みのシーンデータにつきましては、新構造
    に自動で対応することが困難であることが確認されております。

    既に作成済みのシーンがある場合は、シーンの再構築をしていただく必要がござい
    ます。
    また、SsSprite の IntersectsByBounds, ContainsPoint メソッドに引数が追加さ
    れたため、これらメソッドを呼び出している箇所ではコンパイルエラーが発生しま
    す。
    その場合、第２引数に true を指定して呼び出すようにして頂ければ従来と同じ動
    作になります。
    詳しくは script.txt をご覧ください。

    プロジェクトツリーに登録されているアニメーションデータおよびプレハブにつき
    ましては、SSAXファイルを Reimport していただくことで、正しい状態で再度使用
    が可能になることを確認しております。

  ・SSAXファイルフォーマットの仕様は、将来、変更される可能性があります。


■お問い合わせ先

  salesgrp@webtech.co.jp 宛にお願いします。


=============================================================================
株式会社ウェブテクノロジ
http://www.webtech.co.jp/
Copyright(C) 2003-2013 Web Technology Corp.
=============================================================================

* SpriteStudio, Web Technologyは、株式会社ウェブテクノロジの登録商標です。
* その他の商品名は各社の登録商標または商標です。

[End of TEXT]
