// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'user_favorite.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

UserFavorite _$UserFavoriteFromJson(Map<String, dynamic> json) => UserFavorite(
      id: (json['id'] as num?)?.toInt() ?? 0,
      productId: (json['productId'] as num?)?.toInt() ?? 0,
      userId: (json['userId'] as num?)?.toInt() ?? 0,
      createdAt: json['createdAt'] == null
          ? null
          : DateTime.parse(json['createdAt'] as String),
      product: json['product'] == null
          ? null
          : Product.fromJson(json['product'] as Map<String, dynamic>),
      user: json['user'] == null
          ? null
          : User.fromJson(json['user'] as Map<String, dynamic>),
    );

Map<String, dynamic> _$UserFavoriteToJson(UserFavorite instance) =>
    <String, dynamic>{
      'id': instance.id,
      'productId': instance.productId,
      'product': instance.product,
      'userId': instance.userId,
      'user': instance.user,
      'createdAt': instance.createdAt?.toIso8601String(),
    };
