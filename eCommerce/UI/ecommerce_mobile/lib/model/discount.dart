import 'package:ecommerce_mobile/model/product.dart';
import 'package:json_annotation/json_annotation.dart';

part 'discount.g.dart';

@JsonSerializable()
class Discount {
  final int id;
  final int productId;
  final double discount;

  final DateTime? validFrom;
  final DateTime? validTo;

  final double oldPrice;
  final double newPrice;

  final Product? product;

  Discount(
      {this.id = 0,
      this.productId = 0,
      this.discount = 0,
      this.oldPrice = 0,
      this.newPrice = 0,
      this.validFrom,
      this.validTo,
      this.product});

  factory Discount.fromJson(Map<String, dynamic> json) =>
      _$DiscountFromJson(json);

  Map<String, dynamic> toJson() => _$DiscountToJson(this);
}
