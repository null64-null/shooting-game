# シューティングゲーム
<br>

## 概要
Unityを用いた、弾を発射して敵を倒す簡単なゲームの制作
<br><br>

## 開発の目的
Unityを用いたゲーム制作の基本を学習する
<br><br>

## 使用技術
Unity, C#
<br><br>

## プレイの様子
https://github.com/null64-null/shooting-game/assets/127968084/8b9bf2b4-2663-4d08-9511-74987f52985e

### 操作
- PCの方向キーでプレイヤーキューブの動きを操作
- スペースキーで弾を発射
<br><br>

### 動き
#### 敵キューブ
- ランダムな時間間隔で、ランダムな位置に出現する
- ランダムな時間間隔で直進する弾で攻撃してくる
- ランダムな時間間隔で方向転換する
- 他の敵と、壁に衝突した時も方向転換する
  
#### 弾
- プレイヤーが発射した弾は、敵の弾に当たると敵の弾と共に小さく爆発
- プレイヤーが発射した弾が敵キューブに当たると、敵キューブが大きく爆発
- プレイヤーも敵弾に当たると爆発する
- 敵の弾は、他の敵や壁に当たると、爆発なしで消滅する

#### 壁
- 敵の背後の壁に弾が当たると炎上するエフェクトあり
<br><br><br>

## 今後やりたいことなど
- 多少の不具合がありますが、目的とするところまでの理解ができたので、このシューティングゲームの制作を終えました。
- 天体物理の法則を組み込んで、惑星の動きとロケットの動きをシミュレーションできる別のゲームを作ってみたいです。
<br><br>

## ライセンス
本リポジトリのライセンスは、 MIT ライセンスの規約に基づいて付与されています
（LICENCE に記載）
