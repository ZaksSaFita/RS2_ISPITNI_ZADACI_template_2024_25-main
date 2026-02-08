import 'package:ecommerce_mobile/model/cart.dart';
import 'package:ecommerce_mobile/model/product.dart';
import 'package:ecommerce_mobile/providers/base_provider.dart';
import 'package:flutter/widgets.dart';
import 'package:collection/collection.dart';

class CartProvider extends BaseProvider<Cart> {
  Cart cart = Cart();

  CartProvider() : super("cart");
  addToCart(Product product) {
    if (findInCart(product) != null) {
      findInCart(product);
    } else {
      cart.cartItems.add(CartItem(product, 1));
    }

    notifyListeners();
  }

  removeFromCart(Product product) {
    cart.cartItems.removeWhere((item) => item.product?.id == product.id);
    notifyListeners();
  }

  CartItem? findInCart(Product product) {
    CartItem? item = cart.cartItems
        .firstWhereOrNull((item) => item.product?.id == product.id);

    return item;
  }
}
