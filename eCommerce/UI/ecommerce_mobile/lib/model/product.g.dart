// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'product.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Product _$ProductFromJson(Map<String, dynamic> json) => Product(
      id: (json['id'] as num?)?.toInt() ?? 0,
      name: json['name'] as String? ?? '',
      code: json['code'] as String? ?? '',
      description: json['description'] as String? ?? '',
      productState: json['productState'] as String? ?? 'ActiveProductState',
      price: (json['price'] as num?)?.toDouble() ?? 0,
      unitOfMeasureId: (json['unitOfMeasureId'] as num?)?.toInt(),
      productTypeId: (json['productTypeId'] as num?)?.toInt(),
      assets: (json['assets'] as List<dynamic>?)
              ?.map((e) => Asset.fromJson(e as Map<String, dynamic>))
              .toList() ??
          const [],
      productType: json['productType'] == null
          ? null
          : ProductType.fromJson(json['productType'] as Map<String, dynamic>),
      unitOfMeasure: json['unitOfMeasure'] == null
          ? null
          : UnitOfMeasure.fromJson(
              json['unitOfMeasure'] as Map<String, dynamic>),
    );

Map<String, dynamic> _$ProductToJson(Product instance) => <String, dynamic>{
      'id': instance.id,
      'name': instance.name,
      'description': instance.description,
      'code': instance.code,
      'productState': instance.productState,
      'price': instance.price,
      'unitOfMeasureId': instance.unitOfMeasureId,
      'productTypeId': instance.productTypeId,
      'assets': instance.assets,
      'productType': instance.productType,
      'unitOfMeasure': instance.unitOfMeasure,
    };
