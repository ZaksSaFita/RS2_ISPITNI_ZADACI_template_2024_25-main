import 'package:ecommerce_mobile/model/product.dart';
import 'package:ecommerce_mobile/model/user.dart';
import 'package:json_annotation/json_annotation.dart';

part 'user_favorite.g.dart';

@JsonSerializable()
class UserFavorite {
  final int id;
  final int productId;
  final Product? product;
  final int userId;
  final User? user;
  final DateTime? createdAt;

  UserFavorite(
      {this.id = 0,
      this.productId = 0,
      this.userId = 0,
      this.createdAt,
      this.product,
      this.user});

  factory UserFavorite.fromJson(Map<String, dynamic> json) =>
      _$UserFavoriteFromJson(json);

  Map<String, dynamic> toJson() => _$UserFavoriteToJson(this);
}
