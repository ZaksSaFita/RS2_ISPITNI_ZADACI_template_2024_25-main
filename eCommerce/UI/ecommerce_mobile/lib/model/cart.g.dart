// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'cart.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

User _$UserFromJson(Map<String, dynamic> json) => User(
      id: (json['id'] as num?)?.toInt() ?? 0,
      firstName: json['firstName'] as String? ?? "",
      lastName: json['lastName'] as String? ?? "",
    );

Map<String, dynamic> _$UserToJson(User instance) => <String, dynamic>{
      'id': instance.id,
      'firstName': instance.firstName,
      'lastName': instance.lastName,
    };

Cart _$CartFromJson(Map<String, dynamic> json) => Cart(
      id: (json['id'] as num?)?.toInt() ?? 0,
      user: json['user'] == null
          ? null
          : User.fromJson(json['user'] as Map<String, dynamic>),
      cartItems: (json['cartItems'] as List<dynamic>?)
              ?.map((e) => CartItem.fromJson(e as Map<String, dynamic>))
              .toList() ??
          const [],
    );

Map<String, dynamic> _$CartToJson(Cart instance) => <String, dynamic>{
      'id': instance.id,
      'user': instance.user,
      'cartItems': instance.cartItems,
    };

CartItem _$CartItemFromJson(Map<String, dynamic> json) => CartItem(
      id: (json['id'] as num?)?.toInt() ?? 0,
      quantity: (json['quantity'] as num?)?.toInt() ?? 0,
      productId: (json['productId'] as num?)?.toInt() ?? 0,
      product: json['product'] == null
          ? null
          : Product.fromJson(json['product'] as Map<String, dynamic>),
    );

Map<String, dynamic> _$CartItemToJson(CartItem instance) => <String, dynamic>{
      'id': instance.id,
      'quantity': instance.quantity,
      'productId': instance.productId,
      'product': instance.product,
    };
