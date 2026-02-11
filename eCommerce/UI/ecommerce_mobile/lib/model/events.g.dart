// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'events.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Events _$EventsFromJson(Map<String, dynamic> json) => Events(
      id: (json['id'] as num?)?.toInt() ?? 0,
      userFullName: json['userFullName'] as String? ?? "",
      cartId: (json['cartId'] as num?)?.toInt() ?? 0,
      cartItemId: (json['cartItemId'] as num?)?.toInt() ?? 0,
      eventType: json['eventType'] as String? ?? '',
      createdAt: json['createdAt'] == null
          ? null
          : DateTime.parse(json['createdAt'] as String),
      productName: json['productName'] as String? ?? "",
      productPrice: (json['productPrice'] as num?)?.toDouble() ?? 0,
      oldQuantity: (json['oldQuantity'] as num?)?.toInt() ?? 0,
      newQuantity: (json['newQuantity'] as num?)?.toInt() ?? 0,
    );

Map<String, dynamic> _$EventsToJson(Events instance) => <String, dynamic>{
      'id': instance.id,
      'userFullName': instance.userFullName,
      'cartId': instance.cartId,
      'cartItemId': instance.cartItemId,
      'eventType': instance.eventType,
      'createdAt': instance.createdAt?.toIso8601String(),
      'productName': instance.productName,
      'productPrice': instance.productPrice,
      'oldQuantity': instance.oldQuantity,
      'newQuantity': instance.newQuantity,
    };
